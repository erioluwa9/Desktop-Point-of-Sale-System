   M S B A M L   `   `   `  ����O  KPoint of Sale System, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Point_of_Sale_SystemPoint_of_Sale_System  5      #    Point_of_Sale_System.SaleList   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:Point_of_Sale_System     5      V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5          N� Title$  
SaleDetail��5
      .��5      �� ���	#FFDADADA J� Effect 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 20Q�6      Color$ 	#FFB4B4B4��6/      RenderingBias$ Quality=�6A      ShadowDepth$ 1Q�6Y   .+�5   
   � ���	#FF6236B0.+�5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]   Kind$ Details=�6&   
�������$��Center=�6^   $��	292,0,0,0q�6y   $��30��6�   $��29��6�   ��65   Z� 6�   �� 5      $��SALES DETAILS��6   $	��200��6-    �� TextAlignment$ Center=�69   $��Center=�6P   
�������$
��Bold"�6~   $��Calibri)�6�   $��20(�6�   $��Italic$�6�   5      � 5   
   $��	7,0,-36,0q�6   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ mySalesDetailsDatagrid��5      $	��250��67   	   CanUserAddRows	 .  
   
IsReadOnly
 .    AlternatingRowBackground �#DCDCDC$��20��6�   $��
10,40,50,0q�6�   5      5      � 5   
   .+�5        -   5        $ mySalesListDatagrid��5      $	��250��64   	 .  
 .  �#DCDCDC$��20��6�   $��106,28,125,12q�6�   5#      5$      5&      5'      