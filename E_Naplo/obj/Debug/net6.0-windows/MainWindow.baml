   M S B A M L   `   `   `  ����B  >E_Naplo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:E_NaploE_Naplo  5   	       E_Naplo.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:E_Naplo     5   	   -   5          �Name$  foablak��5   	    � Title$ E-Napló��5   	   $	��460��6   $	��850��6&   ���	#FFFFA464 � 
ResizeMode$ CanMinimize=�6`    � Cursor$	 Pen��6y    � WindowState$ 	Maximized=�6�    � WindowStyle$
 None=�6�    � 	Resources 5	         DataGridRowHeaderStyle1 �� 
TargetType:  4System.Windows.Controls.Primitives.DataGridRowHeader �� Property	 �� Value
 �� 
TargetType��%�   &	        �� 5
   
   "  60   .�5      ��  � ��	 5      �� 5      "
  6&   .R�5      � 5      5      5      5      .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ datas��5   a      RowHeaderStyle# �   6   
���   � �� AlternationCount$ 6��6p   $
��Left=�6�   $	��400��6�   $��	10,24,0,0q�6�   $	��Top=�6�      MinColumnWidth$	 100Q�6  ���	#FFFF7F35$	��600��6/  ���	#FFFF7F35   RowStyle 5      �� 5      )  #System.Windows.Controls.DataGridRow"  6   .�5      ��  � ��
	 ��  �6/   �� 5       � ��
	 �����6/    �� Triggers 5      P� 5       P� Property �@��AlternationIndex P� Value$ 0��6C   . �5      ��  � ��
	 �  ��6;   �� 5       � ��
	 �   �6;   5      P� 5        �@��AlternationIndex$ 1��6C   . �5!      ��  � ��
	 � ���6;   �� 5"       � ��	 �	#FF3C3C3C6;   5#      P� 5$       �@��AlternationIndex$ 2��6G   . �5%      ��  � ��
	 � ���6;   �� 5&       � ��
	 �   �6;   5'      P� 5(       �@��AlternationIndex$ 3��6G   . �5)      ��  � ��
	 � d �6;   �� 5*       � ��	 �	#FF3C3C3C6;   5+      P� 5,       �@��AlternationIndex$ 4��6G   . �5-      ��  � ��
	 ��  �6;   �� 5.       � ��
	 �   �6;   5/      P� 50       �@��AlternationIndex$ 5��6G   . �51      ��  � ��
	 �� ��6;   �� 52       � ��	 �	#FF3C3C3C6;   53      55      57      �� 58   
   -   5         ��Name$ searchbutton��58      $��Keresés��6'   $
��Left=�69   $��25��6T   $��671,126,0,0q�6`   $	��Top=�6u   $	��150��6�   $��15(�6�   $��Center=�6�   $��Center=�6�   
����������	#FFFFA4646  �� 59   
   -   5         ��Name$ 
searchtext��59      $
��Left=�6&   $��25��6A   $��
671,96,0,0q�6M    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��150��6�   ���	#FFFF7F356�   �� 5:   
   -   5         ��Name$ selectsearch��5:      $
��Left=�6)   $��25��6D   $��
671,66,0,0q�6P   $	��Top=�6d   $	��150��6|   ���	#FFFF7F35��5;      �� 5<       �� EndPoint$	 0,1&�6&   .��5=      �  � Color$ 	#FFF0F0F0��6#   � 5>      $ White��6#    � Offset$ 1Q�61   5?      5A      �� 5B   
   -   5        $ CreateButton��5B      $��Létrehozás��6'   $
��Left=�6<   $��35��6W   $��688,389,0,0q�6c   $	��Top=�6x   $	��116��6�   
����������	#FFFF7F356�   �� 5C   
   -   5        $ newmark��5C      $��Jegyek megtekintése��6"   $
��Left=�6@   $��24��6[   $��671,212,0,0q�6g   $	��Top=�6|   $	��150��6�   $��15(�6�   
����������	#FFFF7F356�   �� 5D   
   -   5        $ kilepesgomb��5D      $��	Kilépés��6&   $��Right=�68   $��	0,0,45,45q�6T   $��Bottom=�6g   ���	#FFED0F0F6�   5E      5F      