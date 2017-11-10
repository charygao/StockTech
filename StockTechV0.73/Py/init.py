#init our system.
url="http://youkes.com";
#debug
#url="http://localhost";

stockUrl=url+"/stockdata";


def init():
	stk.setStr("stockUrl",stockUrl);
	
init();
