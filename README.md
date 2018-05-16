# NetTest
本项目是基于WCF（Windows Communication Foundatiomn）框架的试题练习程序   
功能：添加试题、删除试题、更新试题、试题练习.
## 支持的环境
系统：__windows__   
本项目在  __Microsoft Visual Studio Ultimate 2012__  编译通过   
Microsoft .Net Framework __Version 4.7.02556__    
数据库：__SQL serve__


## 文件结构
NetTestServer __(服务器端)__   
>+NetTestBLL __业务逻辑层__   
>>[NetTestManager.cs](/NetTestServer/NetTestBLL/TestManager.cs)    
>>[UserManager.cs](/NetTestServer/NetTestBLL/UserManager.cs)   
>
>+NetTestDAl __数据访问层__   
>>-[DBHelper.cs](/NetTestServer/NetTestDAL/DBHelper.cs)   
>>-[TestService.cs](/NetTestServer/NetTestDAL/TestService.cs)      
>>-[UserService.cs](/NetTestServer/NetTestDAL/UserService.cs)   
>
>+NetTsetModel __实体类库层__   
>>-[ModerClass.cs](/NetTestServer/NetTestModel/ModelClass.cs)   
>>-[TsetClass.cs](/NetTestServer/NetTestModel/TestClass.cs)   
>>-[UserClass.cs](/NetTestServer/NetTestModel/UserClass.cs)   
>
>+NerTsetServer   __表现层__   
>>-[INetTestService.cs](/NetTestServer/NetTestServer/INetTestService.cs)   
>>-[NetTestService.cs](/NetTestServer/NetTestServer/NetTestService.cs)    
>>-[Program.cs](/NetTestServer/NetTestServer/Program.cs)   

NetTestClient(客户端)   
>+NetTestClient __(客户端)__    
>
>>-[App.xaml](/NetTestClient/NetTestClient/App.xaml) 文件是程序的起点，定义全局资源，他们可以在整个应援里被访问   
>>-[App.xaml.cs](/NetTestClient/NetTestClient/App.xaml.cs) 是扩展了应用类，它是WPF窗口应用的中心类嘞。  
>__登录界面__
>
>>-[MainWindow.xaml](/NetTestClient/NetTestClient/MainWindow.xaml) 是 __登录界面__ 的布局文件   
>>-[MainWindow.xaml.cs](/NetTestClient/NetTestClient/MainWindow.xaml.cs) 是 __登录界面__ 的代码隐藏文件。其中有用于处理登录的事件    
>__功能选择窗口__
>
>>-[Option.xaml](/NetTestClient/NetTestClient/Option.xaml) 是 __功能选择窗口__ 的布局文件    
>>-[Option.xaml.cs](/NetTestClient/NetTestClient/Option.xaml.cs) 文件用于定义 __功能选择窗口__ 上按钮的事件   
>__习题添加窗口__
>
>>-[AddQuestionWindow.xaml](/NetTestClient/NetTestClient/AddQuestionWindow.xaml) 是 __习题添加窗口__ 的布局文件    
>>-[AddQuestionWindow.xaml.cs](/NetTestClient/NetTestClient/AddQuestionWindow.xaml.cs) 用于定义 __习题添加窗口__  窗口的事件函数以及一些处算法逻辑
>__习题更新窗口__
>
>>-[UpdateQuestionWindow.xaml](/NetTestClient/NetTestClient/UpdateQuestionWindow.xaml) 是 __习题更新窗口__ 的布局文件     
>>-[UpdateQuestionWindow.xaml.cs](/NetTestClient/NetTestClient/UpdateQuestionWindow.xaml.cs)  用于定义 __习题更新窗口__  窗口的事件函数以及一些处算法逻辑   
>__习题删除窗口__   
>
>>-[DeleteQuestionWindow.xaml](/NetTestClient/NetTestClient/DeleteQuestionWindow.xaml) 是 __习题删除窗口__ 的布局文件   
>>-[DeleteQuestionWindow.xaml.cs](/NetTestClient/NetTestClient/DeleteQuestionWindow.xaml.cs) 用于定义 __习题删除窗口__  窗口的事件函数以及一些处算法逻辑     
>__习题练习窗口__   
>
>>-[ExerciseWindow.xaml](/NetTestClient/NetTestClient/ExerciseWindow.xaml) 是 __练习习题窗口__ 的布局文件     
>>-[ExerciseWindow.xaml.cs](/NetTestClient/NetTestClient/ExerciseWindow.xaml.cs) 用于 __练习习题窗口__ 窗口的事件函数以及一些处算法逻辑     

## 部署

## MIT License
=======
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
