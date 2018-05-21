# NetTest 作者：王旭
本项目是基于 ___WCF（Windows Communication Foundatiomn）___ 框架的试题练习程序  作者 
功能：   
* 添加试题
* 删除试题
* 更新试题
* 试题练习
## 支持的环境
系统：___Windows___   
本项目在  ___Microsoft Visual Studio Ultimate 2012___  编译通过   
Microsoft .Net Framework ___Version 4.7.02556___    
数据库：___SQL Serve___

## 文件结构
NetTestServer __(服务器端)__    
>
>+NetTestBLL ___业务逻辑层___   
>>-[NetTestManager.cs](/NetTestServer/NetTestBLL/TestManager.cs)   
>>-[UserManager.cs](/NetTestServer/NetTestBLL/UserManager.cs)   
>>`对传送数据进行逻辑判断分折，并进行传送正确的值。`   
>
>+NetTestDAl ___数据访问层___   
>>-[DBHelper.cs](/NetTestServer/NetTestDAL/DBHelper.cs)   
>>`数据库的连接，一些基本访问函数`   
>>-[TestService.cs](/NetTestServer/NetTestDAL/TestService.cs)    
>>`对数据库表的一些基本操作，给tests添加新字段函数，删除tests字段函数,更新test字段函数,得到10条tests表记录函数，添加marks表字段函数`    
>>-[UserService.cs](/NetTestServer/NetTestDAL/UserService.cs)     
>>`对users表的操作，添加，查询`   
>
>+NetTsetModel ___实体类库层___   
>>-[TsetClass.cs](/NetTestServer/NetTestModel/TestClass.cs)   
>>`存放数据库 tests 表的字段`   
>>-[UserClass.cs](/NetTestServer/NetTestModel/UserClass.cs)   
>>`存放数据库 users 表的字段`  
>
>+NerTsetServer ___表现层___   
>>-[INetTestService.cs](/NetTestServer/NetTestServer/INetTestService.cs)   
>>`wcf服务的接口`   
>>-[NetTestService.cs](/NetTestServer/NetTestServer/NetTestService.cs)    
>>`此处实现接口函数`   
>>-[Program.cs](/NetTestServer/NetTestServer/Program.cs)    
>>`调用接口实现控制台程序c从而启动wcf服务`   

+NetTestClient __(客户端)__     
>
>>-[App.xaml](/NetTestClient/NetTestClient/App.xaml)    
>>`文件是程序的起点，定义全局资源，他们可以在整个应援里被访问 `  
>>-[App.xaml.cs](/NetTestClient/NetTestClient/App.xaml.cs)    
>>`是扩展了应用类，它是WPF窗口应用的中心类`   
>
>__登录界面__
>>-[MainWindow.xaml](/NetTestClient/NetTestClient/MainWindow.xaml)   
>>`是 `___登录界面___` 的布局文件`   
>>-[MainWindow.xaml.cs](/NetTestClient/NetTestClient/MainWindow.xaml.cs)   
>>`是 `___登录界面___` 的代码隐藏文件。其中有用于处理登录的事件`    
>
>__功能选择窗口__
>>-[Option.xaml](/NetTestClient/NetTestClient/Option.xaml)    
>>`是 `___功能选择窗口___` 的布局文件`   
>>-[Option.xaml.cs](/NetTestClient/NetTestClient/Option.xaml.cs)   
>>`文件用于定义 `___功能选择窗口___` 上按钮的事件`   
>
>__习题添加窗口__
>>-[AddQuestionWindow.xaml](/NetTestClient/NetTestClient/AddQuestionWindow.xaml)   
>>`是 `___习题添加窗口___` 的布局文件`    
>>-[AddQuestionWindow.xaml.cs](/NetTestClient/NetTestClient/AddQuestionWindow.xaml.cs)   
>>`用于定义 `___习题添加窗口___`  窗口的事件函数以及一些处算法逻辑`   
>
>__习题更新窗口__
>>-[UpdateQuestionWindow.xaml](/NetTestClient/NetTestClient/UpdateQuestionWindow.xaml)   
>>`是 `___习题更新窗口___` 的布局文件`     
>>-[UpdateQuestionWindow.xaml.cs](/NetTestClient/NetTestClient/UpdateQuestionWindow.xaml.cs)   
>>`用于定义 `___习题更新窗口___`  窗口的事件函数以及一些处算法逻辑`   
>
>__习题删除窗口__   
>>-[DeleteQuestionWindow.xaml](/NetTestClient/NetTestClient/DeleteQuestionWindow.xaml)   
>>`是 `___习题删除窗口___` 的布局文件`   
>>-[DeleteQuestionWindow.xaml.cs](/NetTestClient/NetTestClient/DeleteQuestionWindow.xaml.cs)   
>>`用于定义 `___习题删除窗口___`  窗口的事件函数以及一些处算法逻辑`   
>    
>__习题练习窗口__   
>>-[ExerciseWindow.xaml](/NetTestClient/NetTestClient/ExerciseWindow.xaml)   
>>`是 `___练习习题窗口___` 的布局文件`  
>>-[ExerciseWindow.xaml.cs](/NetTestClient/NetTestClient/ExerciseWindow.xaml.cs)   
>>`用于 `___练习习题窗口___` 窗口的事件函数以及一些处算法逻辑`

## 部署
部署超级简单   
 1. 数据库部分参考[NetTest_Database.sql](NetTestServer/NetTest_Database.sql)文件进行数据库创建。    
 2. 连接数据库部分请更改[DB_config.ini](/NetTestServer/NetTestServer/bin/Debug/DB_config.ini)
   Server=为数据库名称;
   UserName=数据库用户名;
   UserPass=用户名密码；
   DataBase=数据库名称;
 3. 重新生成过后请用管理员身份运行[NetTestServer.exe](/NetTestServer/NetTestServer/bin/Debug/NetTestServer.exe)文件，作为服务器端。     
 4. 请启动[NetTestClient.exe](/NetTestClient/NetTestClient/bin/Debug/NetTestClient.exe)作为客户端。  

MIT License
======
Copyright (c) 2018 wx98

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
