   M S B A M L   `   `   `  ����  NetTestClient    NetTestClient.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  登录试题练习程序��5   	   $	��350��6   $	��525��6'    � WindowStartupLocation$ CenterScreen=�63    � 
ResizeMode$ NoResize=�6X   .��5      �  � RowDefinitions 5   
   �� 5      $	��150 �6   �� 5      $��50 �6   �� 5	      $��50 �6   �� 5
      $��50 �6   .+�5   
   �� $��0��6   $��Center=�6#   .+�5      �� $$��基于WCF的试题练习程序��6   $��0,50,0,0q�6+   $��40(�6=   $	��Top=�6K   $��Right=�6c   5      �� 5   
    �� Orientation$ 
Horizontal=�6   $��1��6/   $��Center=�6=   .+�5      �� $��
用户名:��6   $��23��6$   $��50��60   $��	10,10,0,0q�6;   �� 5      -   5         ��Name$ txtUser��5      $��	10,10,0,0q�6(   $��23��6;   $	��150��6G   5      �� 5   
   $ 
Horizontal=�6   $��2��6.   $��Center=�6<   .+�5      �� $��密码:��6   $��23��6#   $��50��6/   $��10,0,0,0q�6:   G� 5      -   5         G�Name$ txtPass��5      $��10,0,0,0q�6+   $��23��6=   $	��150��6I   5      �� 5   
   $ 
Horizontal=�6   $��3��6.   $��Center=�6<   .+�5      �� -   5         ��Name$ btLogin��5      $��注册登录��6&   $
��Left=�5      $	��Top=�6-   $��	10,10,0,0q�5      $��23��6%   $��74��61    �� 	IsDefault . 6<   5      5      5      