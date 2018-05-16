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
>-NetTestBLL __业务逻辑层__   
>>-[NetTestManager.cs](NetTestServer\NetTestBLL\\TestManager.cs)    
>>-[UserManager.cs](NetTestServer\NetTestBLL\\UserManager.cs)   
>
>-NetTestDAl __数据访问层__   
>>-[DBHelper.cs](NetTestDAL\DBHelper.cs)   
>>-[TestService.cs](NetTestDAL\TestService.cs)      
>>-[UserService.cs](NetTestDAL\UserService.cs)   
>
>-NetTsetModel __实体类库层__   
>>-[ModerClass.cs](NetTestModel\ModelClass.cs)   
>>-[TsetClass.cs](NetTestModel\TestClass.cs)   
>>-[UserClass.cs](NetTestModel\UserClass.cs)   
>
>-NerTsetServer   __表现层__   
>>-[INetTestService.cs](NetTestServer\INetTestService.cs)   
>>-[NetTestService.cs](NetTestServer\NetTestServer.cs)    
>>-[Program.cs](NetTestServer\Program.cs)   

NetTestClient(客户端)   
>NetTestClient __(客户端)__
>>[App.xaml](NetTestClient\App.xaml)   
>>[App.xaml.cs](NetTestClient\App.xaml.cs)   
>>[MainWindow.xaml](NetTestClient\MainWindow.xaml)   
>>[MainWindow.xaml.cs](NetTestClient\MainWindow.xaml.cs)   
>>[Option.xaml](NetTestClient\Option.xaml)   
>>[Option.xaml.cs](NetTestClient\Option.xaml.cs)   
>>[AddQuestionWindow.xaml](NetTestClient\AddQuestionWindow.xaml)   
>>[AddQuestionWindow.xaml.cs](NetTestClient\AddQuestionWindow.xaml.cs)   
>>[UpdateQuestionWindow.xaml](NetTestClient\UpdateQuestionWindow.xaml)   
>>[UpdateQuestionWindow.xaml.cs](NetTestClient\UpdateQuestionWindow.xaml.cs)   
>>[DeleteQuestionWindow.xaml](NetTestClient\DeleteQuestionWindow.xaml)   
>>[DeleteQuestionWindow.xaml.cs](NetTestClient\DeleteQuestionWindow.xaml.cs)   
>>[ExerciseWindow.xaml](NetTestClient\ExerciseWindow.xaml)   
>>[ExerciseWindow.xaml.cs](NetTestClient\ExerciseWindow.xaml.cs)   

## 部署


MIT License
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
