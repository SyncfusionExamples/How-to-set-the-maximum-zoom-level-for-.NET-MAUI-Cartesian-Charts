using System.Collections.ObjectModel;

namespace MaximumZoomLevel
{
    public class ViewModel
    {
        public ObservableCollection<Model> Data2 { get; set; }

        public ObservableCollection<Brush> pale { get; set; }

        public ViewModel()
        {
            Data2 = new ObservableCollection<Model>()
            {
                new Model(3, 1),   
                new Model(7, 2),  
                new Model(13, 3),  
                new Model(6, 4),  
                new Model(5, 5), 
                new Model(7, 6),  
                new Model(10, 7),  
                new Model(5, 8),   
                new Model(8, 9),  
                new Model(6, 10),  
                new Model(4, 11),  
                new Model(6, 12),  
                new Model(5, 13),  
                new Model(7, 14),  
                new Model(6, 15), 
                new Model(4, 16), 
                new Model(5, 17), 
                new Model(8, 18),  
                new Model(9, 19),   
                new Model(4, 20)  
            }; 

            pale = new ObservableCollection<Brush>()
            {
                new SolidColorBrush(Color.FromArgb("#FF5733")),  // Bright Red-Orange
                new SolidColorBrush(Color.FromArgb("#FF8C00")),  // Vivid Orange
                new SolidColorBrush(Color.FromArgb("#FFC300")),  // Warm Yellow
                new SolidColorBrush(Color.FromArgb("#FFD700")),  // Rich Gold
                new SolidColorBrush(Color.FromArgb("#ADFF2F")),  // Fresh Green-Yellow
                new SolidColorBrush(Color.FromArgb("#32CD32")),  // Vibrant Lime Green
                new SolidColorBrush(Color.FromArgb("#20B2AA")),  // Light Sea Green
                new SolidColorBrush(Color.FromArgb("#00CED1")),  // Bright Cyan
                new SolidColorBrush(Color.FromArgb("#1E90FF")),  // Vivid Sky Blue
                new SolidColorBrush(Color.FromArgb("#4169E1")),  // Royal Blue
                new SolidColorBrush(Color.FromArgb("#6A5ACD")),  // Soft Indigo
                new SolidColorBrush(Color.FromArgb("#8A2BE2")),  // Deep Violet
                new SolidColorBrush(Color.FromArgb("#C71585")),  // Rich Pink-Magenta
                new SolidColorBrush(Color.FromArgb("#FF1493")),  // Deep Pink
                new SolidColorBrush(Color.FromArgb("#FF69B4")),  // Soft Hot Pink
                new SolidColorBrush(Color.FromArgb("#F08080")),  // Warm Coral Red
                new SolidColorBrush(Color.FromArgb("#FA8072")),  // Salmon
                new SolidColorBrush(Color.FromArgb("#E9967A")),  // Dusty Rose
                new SolidColorBrush(Color.FromArgb("#D2691E")),  // Warm Chocolate Brown
                new SolidColorBrush(Color.FromArgb("#A52A2A"))   // Rich Earthy Brown 
            }; 
        } 
    }
}
