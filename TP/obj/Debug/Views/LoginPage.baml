   M S B A M L   `   `   `  ����=  9TP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:TPTP  5   	   -clr-namespace:TP.ConvertersTP.Converters  5   	       TP.LoginPage   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:TP     5   	   2
convertersclr-namespace:TP.Converters     5   	     � 
ResizeMode$  NoResize=�5	   	    � Title$ Login��5
   	   $	��225��6   $	��350��6$    � 	Resources 5      -   'TP.Converters.BoolToVisibilityConverter   BoolToVisibilityConverter��%   &	          5   
   6/   5      .��5      �� .+�5   
   �� $��
Login Page��6   
���   �$��20(�69   $��Center=�6G   $��20q�6d   �� 5   
   $��UserID��6   
���   �$��12(�65   $��Center=�6C   $	��5,0q�6`   �� 5   
   -   5         ��Name$ UserName��5   +   
�������$��100,5q�6=   ��6L   �� *Login+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5   
   $��Log In��6    �� 	IsDefault . $��100,15q�6X   ��63   �� *LogUserInCommand+6X   �� 5   
   
�������y�6$   �� *IsBusy+ �� 	Converter# [  ._�5      � $��Center=�6    � IsIndeterminate . $��20��6L   $	��200��6X   6f   5      5       5"      