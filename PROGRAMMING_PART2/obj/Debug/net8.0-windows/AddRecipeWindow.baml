   M S B A M L   `   `   `  ����L  HPROGRAMMING_PART2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:PROGRAMMING_PART2PROGRAMMING_PART2  5   	   '    !PROGRAMMING_PART2.AddRecipeWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:PROGRAMMING_PART2     5   	     � Title$  AddRecipeWindow��5   	   $	��450��6!   $	��800��6.   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   $��39.96��6*   �� 5      $
��Auto �6   $��0��6*   .+�5   
   �� $��0��6   $��10,10,10,10q�6!   $��Recipe Name:��66   �� 5   
   -   5         ��Name$ RecipeNameTextBox��5      $��1��6-   $��10,10,10,10q�6:   �� 5   
   $��2��6   $��10,10,10,10q�6!   $��Ingredients:��66   �� 5   
   -   5        $ IngredientsTextBox��5      $��3��6.   $��10,10,10,10q�6;    �� TextWrapping$
 Wrap=�6P   " �� VerticalScrollBarVisibility$
 Auto=�6d   �� 5   
   $��4��6   $��10,10,10,10q�6!   $��Steps:��66   �� 5   
   -   5        $ StepsTextBox��5      $��5��6(   $��10,10,10,10q�65   $
 Wrap=�6J   $
 Auto=�6^   �� 5!   
   $��6��6   $��10,10,10,10q�6!   $��	Calories:��66   �� 5"   
   -   5        $ CaloriesTextBox��5"      $��7��6+   $��10,10,10,10q�68   �� 5$   
   $��8��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   $��	0,10,0,10q�6X   $��78��6k   .+�5%      �� -   5         ��Name$ 
SaveButton��5%      $
��Save��6)   $��5q�6Q   �� 5&      -   5        $ CancelButton��5&      $��Cancel��6+   6<   5'      �� 5)   
   -   5        $ ViewDetailsButton��5)      $��View Details��6,   $��9��6C   $��Center=�6p   $��	0,10,0,10q�6�   $��68��6�   5*      5+      