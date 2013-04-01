using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

using EnvDTE80;


namespace TestGuiApp
{
    class GUIController
    {
        private Queue<ICommandDelegate> queue_;
        private Thread worker_;

        public GUIController()
        {
            queue_ = new Queue<ICommandDelegate>();
        }

        ~GUIController() 
        {
            JoinWorker();
        }
        
        public void AddCommand(ICommandDelegate command)
        {
            lock (queue_)
            {
                queue_.Enqueue(command);
                if (queue_.Count != 1)
                    return;
            }
            JoinWorker();
            worker_ = new Thread(new ThreadStart(DispatchEvent));
            worker_.SetApartmentState(ApartmentState.STA);
            worker_.Start();
        }
        
        private void DispatchEvent()
        {
            while (true)
            {
                ICommandDelegate command = null;

                lock (queue_)
                {
                    if (queue_.Count > 0)
                        command = queue_.Peek();
                }
                
                if (command == null) 
                    break;
                
                try
                {
                    command();
                }
                catch (System.Exception ex)
                {
                    System.Console.WriteLine(ex.ToString());
                }
             
                lock (queue_) 
                {
                    queue_.Dequeue();
                }
           
            }
        }

        private void JoinWorker()
        {
            if (worker_ != null)
                worker_.Join();
        }
    }
}
