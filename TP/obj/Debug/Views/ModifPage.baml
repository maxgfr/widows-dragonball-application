   M S B A M L   `   `   `  ����=  9TP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:TP.ViewsTP.Views  5   	       TP.Views.ModifPage   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:TP.Views     5   	     � Title$  	ModifPage��5   	   $	��500��6   $	��500��6(   .��5
      � ��5   
   �� 5       j� 
AlignmentY$	 Top=�6    j� 
AlignmentX$ Center=�6*    j� Stretch$ UniformToFill=�6>    �� ImageSource$% /TP;component\Assets\dbteam.jpg��6V    � RowDefinitions 5   
   �� 5      $��15 �6   �� 5      $��* �6   �� 5      $��25 �6   .+�5   
   �� $��0��6   $��Add an element :��6!   
���   �$��12(�6L   $��Center=�6Z   $	��5,0q�6w   � 5   
   $��1��6    5      �� 5      $��* �6    �� 5      $��* �6    �� 5      $��* �6    �� 5      $��* �6    �� 5      $��* �6     � ColumnDefinitions 5!      �� 5"      $��90 �6#   �� 5#      $��* �6#   .+�5&      �� $��0��6   $��Name :��6%   
���  ��$
��Bold"�6D   $��10(�6X   $��Center=�6f   $	��5,0q�6�   $��Center=�6�   �� 5'      $��1��6   $��Breed :��6%   
���  ��$��10(�6E   $
��Bold"�6S   $��Center=�6e   $	��5,0q�6�   $��Center=�6�   �� 5(      $��2��6   $��Description :��6%   
���  ��$��10(�6K   $
��Bold"�6Y   $��Center=�6l   $	��5,0q�6�   $��Center=�6�   �� 5)      $��3��6   $��Main Image : ��6%   
���  ��$��10(�6K   $
��Bold"�6Y   $��Center=�6k   $	��5,0q�6�   $��Center=�6�   �� 5*      $��4��6   $��Secondary Image :��6%   
���  ��$��10(�6O   $
��Bold"�6]   $��Center=�6o   $��Center=�6�   �� 5,      -   5         ��Name$
 Name��5,   3   $��1��6   $��0��6&   
�������$��5q�6[   ��6f   �� *ModificationCharacter.Name+ �� Mode$ TwoWay=�	 �� UpdateSourceTrigger$	 PropertyChanged=��� 5-      -   5        $
 Race��5-   3   $��1��6   $��1��6&   
�������$��5q�6[   ��6f   �� *ModificationCharacter.Race+$ TwoWay=�$	 PropertyChanged=��� 5.      $��1��6   $��2��6)   .+�5/      �� -   5        $ Description��5/      
�������$	��5,0q�6H   "
 �� VerticalScrollBarVisibility$

 Auto=�6V   ��6y   �� *#!ModificationCharacter.Description+$ TwoWay=�$	 PropertyChanged=��� 50      -   5        $��Add a description��50      $	��0,5q�6W   $	��200��6d   $��Center=�6p   51      �� 52      $��1��6   $��3��6)   .+�53      �� -   5        $ Image��53   .   $y�Hidden=�6   
�������$	��5,0q�6V   $

 Auto=�6d   ��6�   �� *ModificationCharacter.Image+$ TwoWay=�$	 PropertyChanged=��� 54      -   5        $��Add an image��54      $	��200��6M   $��Center=�6Y   55      �� 56      $��1��6   $��4��6)   .+�57      �� -   5        $ ImageTransfo��57   .   $y�Hidden=�6   
�������$

 Auto=�6^   ��6�   �� *$"ModificationCharacter.ImageTransfo+$ TwoWay=�$	 PropertyChanged=��� 58      -   5        $��Add an image��58      $
��0,-5q�6S   $	��200��6a   $��Center=�6m   59      5;      �� 5<   
   $��2��6   $��10(�6   $��Finish��6,   $��Center=�6a   $	��100��6~   $��20��6�   ��6=   �� *ValidateCommand+6�   5=      5?      