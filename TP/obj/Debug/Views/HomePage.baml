   M S B A M L   `   `   `  ����=  9TP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:TPTP  5   	       TP.HomePage   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:TP     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5	      � ��5   
   �� 5       j� 
AlignmentY$	 Top=�6    j� 
AlignmentX$ Center=�6*    j� Stretch$ UniformToFill=�6>    �� ImageSource$$ /TP;component\Assets\dball.jpg��6V    � ColumnDefinitions 5   
   �� 5      $��90 �6   �� 5      .+�5   
   �� 
�������$��0��6(   ._�5      �  � RowDefinitions 5      �� 5      $��* �6$   �� 5      $��20 �6$   .+�5      �� 
�������$��0��61   ��6>   �� *Items+ �� SelectedItem 6\   �� *SelectedCharacter+ �� Mode$ TwoWay=���5      �� 5      	 �� DataType$	 models:Character��6'   .R�5      �� .+�5    "   �� $��40��6(   $��Uniform=�64   ��6F   �� *Image+6a   5!      5"      5$      �� 5&      -   5        
 ��Name$	
 add��5&   D   $��Ajouter��6Q   $��1��6c   $��90��6p   
���������6   �� *CreateCharacterCommand+6{   5(      5)      �� 5,   
   $��1��6   ._�5-      �  5.      �� 5/      $��* �6$   �� 50      $��40 �6$   .+�53      �� .��54      �� $��0��6!   .+�55      �� $��Center=�6L   $
��Bold"�6i   $��Italic$�6{   $��25(�6�   ��6$   �� *SelectedCharacter.Name+6�   �� 56      $
��Left=�6L   ��6$   �� *SelectedCharacter.Race+6i   �� 57      $
��Wrap=�6$   $
��Left=�6h   ��68   �� *SelectedCharacter.Description+6�   �� 58      $	��180��6    $��Uniform=�6-   $	��230��6q   ��6?   �� * SelectedCharacter.ImageTransfo+6   59      5:      �� 5<      -   5        $
 delete��5<   D   $��	Supprimer��6T   $��1��6h   $��1��6x   $��Center=�6�   $	��150��6�   $��40��6�   ��6   �� *DeleteCharacterCommand+6�   5>      5?      5A      5B      