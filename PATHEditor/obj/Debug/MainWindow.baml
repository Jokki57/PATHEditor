   M S B A M L   `   `   `  ����E  APATHEditor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:PATHEditor
PATHEditor  5   	       PATHEditor.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:PATHEditor     5   	     � Title$  PATH Editor��5   	   $	��400��6   $	��525��6*   .��5	      � .+�5
   
   �� -   5         ��Name$ 
valuesList��5
      $
��Left=�6&   $	��264��6A   $��	10,10,0,0q�6N   $	��Top=�6a   $	��392��6y   5      �� 5   
   -   5         ��Name$ writeButton��5      $��Write to PATH��6&   $
��Left=�6>   $��
407,10,0,0q�6Y   $	��Top=�6m   $	��100��6�   �� 5   
   -   5         ��Name$ valueTextBox��5      $
��Left=�6(   $��24��6C   $��
10,293,0,0q�6O    �� TextWrapping$
 Wrap=�6c   $�� ��6w   $	��Top=�6   $	��497��6�   �� 5   
   -   5        $ updateButton��5      $��Update List��6'   $
��Left=�6=   $��
407,35,0,0q�6X   $	��Top=�6l   $	��100��6�   �� 5   
   -   5        $ addValue��5      $��	Add Value��6#   $
��Left=�67   $��
407,71,0,0q�6R   $	��Top=�6f   $	��100��6~   �� 5   
   -   5        $ removeValue��5      $��Remove Value��6&   $
��Left=�6=   $��
407,96,0,0q�6X   $	��Top=�6l   $	��100��6�   �� 5   
   -   5        $ fullValueTextBox��5      $
��Left=�6,   $��24��6G   $��
10,335,0,0q�6S   $�� ��6g   $	��Top=�6o   $	��497��6�    J� 	AllowDrop .   �� 
IsReadOnly . 6�   �� 5   
   $��Current value editing��6   $
��Left=�60   $��
10,271,0,0q�6K   $	��Top=�6_   �� 5   
   $��Full PATH value��6   $
��Left=�6*   $��
10,314,0,0q�6E   $	��Top=�6Y   5      5      