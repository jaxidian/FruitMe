using System.Collections.Generic;

namespace FruitMe
{
    // I had to escape some double quotes in multiple of these.
    // Maybe we should put these into .txt files or something better?
    // Sounds like a future opportunity!
    // For now, let's try to keep all art to 20 lines or less.
    // Do feel free to offer more elaborate art than 
    public static class Fruit
    {
        public static readonly Dictionary<string, string> AllFruits = new Dictionary<string, string>
        {
            {"an apple", Fruit.Apple},
            {"a banana", Fruit.Banana},
            {"some grapes", Fruit.Grapes},
            {"a lemon", Fruit.Lemon},
            {"an orange", Fruit.Orange},
            {"a peach", Fruit.Peach},
            {"a pear", Fruit.Pear},
            {"a pumpkin", Fruit.Pumpkin}
        };

        // Source: https://ascii.co.uk/art/fruit
        public const string Apple = @"
 ,(.
(   )
 `""'
    ";

        // Source: https://ascii.co.uk/art/fruit
        public const string Pear = @"
  (
 / \
(   )
 `""'
    ";

        // Source: https://ascii.co.uk/art/fruit
        public const string Banana = @"
 ,
 \`.__.
  `._,'
    ";

        // Source: https://ascii.co.uk/art/fruit
        public const string Orange = @"
 ,=.
(.`:)
 `-'
    ";

        // Source: https://ascii.co.uk/art/fruit
        public const string Lemon = @"
 ,.
(:;)
 `'
    ";

        // Source: https://ascii.co.uk/art/fruit
        public const string Grapes = @"
  \
 ()()
()()()
 ()()
  ()
    ";

        // Source: https://ascii.co.uk/art/fruit
        public const string Peach = @"
 ,:.
(:::)
 `-'
    ";
        // Source: https://ascii.co.uk/art/fruit
        public const string Pumpkin = @"
 ,).
((|))
 ``'
        ";    
    }
}