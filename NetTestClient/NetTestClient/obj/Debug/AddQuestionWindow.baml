   M S B A M L   `   `   `  ����  NetTestClient%    NetTestClient.AddQuestionWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  AddQuestionWindow��5   	   $	��350��6#   $	��525��60    � WindowStartupLocation$ CenterScreen=�6<   .��5      �  � RowDefinitions 5   
   �� 5      $��35 �6   �� 5      $��* �6   �� 5	      $��50 �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6$   .+�5      �� -   5         ��Name$ txtMsg_Copy2��5      $��10,0,0,0q�60   $��23��6B   $��40��6N   $��标题��6Y   �� 5      -   5         ��Name$ txtTitle��5      $��10,0,0,0q�60   $��23��6B   $	��440��6N   5      �� 5   
   $��1��6   $ Vertical=�6"   .+�5      �� $
��Left=�6   .+�5      �� -   5        $ txtMsg_Copy3��5      $��10,0,0,0q�60   $��23��6B   $	��200��6N   $��试题内容：��6[   5      �� 5      $
��Left=�6   .+�5      �� -   5        $ txtText��5      $��10,0,0,0q�60   $	��200��6C   $	��490��6P    �� AcceptsReturn . $ �� HorizontalScrollBarVisibility$
 Auto=�6r   " �� VerticalScrollBarVisibility$
 Auto=�6�   6�   5      5      �� 5   
   $��2��6   $ 
Horizontal=�6#   .+�5      �� -   5        $ txtMsg_Copy4��5      $��10,0,0,0q�60   $��23��6B   $��40��6N   $��	答案：��6Z   �� 5      -   5        	 ��Name$	 cbAnswer��5      $��
10,10,0,10q�60   $��23��6D   $��74��6P   �� 5      -   5        
 ��Name$
 btUpload��5      $��
10,10,0,10q�60   $��23��6D   $��74��6P   $��试题上传��6\    �� 	IsDefault . 6�   �� 5      -   5         ��Name$ txtMsg��5      $��
10,20,0,10q�60   $��23��6D   $	��100��6P   $��	TextBlock��6\   5      5      5      