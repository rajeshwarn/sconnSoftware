   M S B A M L   `   `   `  ���� C  ?sconnRem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:sconnRem.PropertiessconnRem.Properties      sconnRem.sconnView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     2prop!clr-namespace:sconnRem.Properties     -     �Name$  sconnRem�� � Title$ SconnRem�� � WindowState$ 	Maximized=� � Icon$2 ,pack://application:,,,/images/worldlock2.jpg��.���  � RowDefinitions �� $
��.05* ��� $
��.10* ��� $
��.85* � � ColumnDefinitions �� $��.100* �.+�� $��0��$��0��.+�o� $��Stretch=�$��0,10,-2,-16q�$��Stretch=�.@�m� -    m�Name$ fileMenuItem��#   sconnRem.Properties.Resources   mitemFileHeader#��Z $��50��$��Stretch=�$��0,0,0,5q�����  �� RelativeSource �� *FindAncestor+	 �� AncestorType"	 o�
 �� Path$
 ActualHeight�.@�m� -   $ SaveMenuItem__Save_��   msubitemSaveHeader#��Z $
��Left=�$	��145��m� -   $ SaveAsMenuItem_Save_As_��   msubitemSaveAsHeader#��Z $
��Left=�$	��145��m� -   $ ImportMenuItem_Import_��   msubitemImportHeader#��Z $
��Left=�$	��145��m� -   $ setupMenuItem��   mitemSetupHeader#��Z $��50��$��Stretch=�$��0,0,0,5q�����  �� *FindAncestor+"	 o�$
 ActualHeight�m� -   $ helpMenuItem��   mitemHelpHeader#��Z $��50��$��Stretch=�$��0,0,0,5q�����  �� *FindAncestor+"	 o�$
 ActualHeight�m� -   $ saveConfigMenuItem��   mitemSaveHeader#��Z m� -	      mitemAboutHeader#��Z m� -
   $ languageMenuItem��   mitemLanguageHeader#��Z .@�m� -   $ Lang1��$��English��$
��Left=�$	��145��m� -   $ Lang12��$��Polski��$
��Left=�$	��145��m� -   $ Lang13��$��Deutsch��$
��Left=�$	��145��m� -   $��
Connection��� $��1��$��0��$��0,19,0,0q� �� $��1* � �� $
��.33* ��� $
��.33* ��� $
��.33* �.+��� -    ��Name$ btnSites��$��Sites��$��0��$��	0,0,169,0q�����  �� *Self+$
 ActualHeight�����  �� *FindAncestor+"	 ��$
 ActualHeight��� -   $ 	btnConfig��$��Config��$��1��$��	0,0,165,0q�����  �� *Self+$
 ActualHeight�����  �� *FindAncestor+"	 ��$
 ActualHeight��� -   $ btnMap��$	��Map��$��2��$
��Left=�$��1������  �� *Self+$
 ActualHeight�����  �� *FindAncestor+"	 ��$
 ActualHeight�� $��2��$��0�� �� $��.100* � �� $
��.20* ��� $
��.80* �.+��� $��0��$��0��$
��auto=�$��Visible=����� *ActualHeight+ �� *FindAncestor+"	 ������ *ActualWidth+ �� *FindAncestor+"	 ��.���� -    ��Name$ siteList��$��Stretch=�$��Stretch=�$
��Auto������ *ActualWidth+ �� *FindAncestor+"	 ���� $��0��$��1��$
��auto=�$��Visible=�$��2������ *ActualHeight+ �� *FindAncestor+"	 ������ *ActualWidth+ �� *FindAncestor+"	 ��.���� -   $ dataView��$��Stretch=�$��Stretch=�$
��Auto������ *ActualWidth+ �� *FindAncestor+"	 ��