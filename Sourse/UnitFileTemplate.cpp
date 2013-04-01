#define BOOST_TEST_MAIN

#include <boost/test/unit_test.hpp>
#include <boost/test/included/unit_test.hpp>
#include <boost/filesystem.hpp>
using namespace std;

string GetDebugFolderPath()
  {
    char buffer[MAX_PATH];
    GetModuleFileName( NULL, buffer, MAX_PATH );
    string::size_type pos = string( buffer ).find_last_of( "\\/" );
    return string( buffer ).substr( 0, pos);
  }

std::string LogFilePath(GetDebugFolderPath());
void CreateFolder() 
{
	boost::filesystem::path dir(LogFilePath + "\\LogFiles");
	boost::filesystem::create_directory(dir);
}

struct MyConfig {
		
	MyConfig() : test_log( LogFilePath + "\\LogFiles\\LogFile.xml")  {
	boost::unit_test::unit_test_log.set_format( boost::unit_test::XML);
	boost::unit_test::unit_test_log.set_stream( test_log );

	}
	~MyConfig(){ 

		test_log << "</TestLog>" << std::flush;  //исправление бага
		boost::unit_test::unit_test_log.set_stream( std::cout );
	} 
    
	std::ofstream test_log;
	

}; 

struct CreateFolderLogFiles{

	CreateFolderLogFiles()
	{
			CreateFolder(); 
	}

};

BOOST_GLOBAL_FIXTURE( CreateFolderLogFiles );

BOOST_GLOBAL_FIXTURE( MyConfig );


////////////////////////////////////////////////////


BOOST_AUTO_TEST_CASE(Test)
{
	BOOST_CHECK(1 == 2);
}



