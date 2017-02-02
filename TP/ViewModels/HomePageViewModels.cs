using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP.Models;
using System;
using Prism.Mvvm;
using System.IO;
using Prism.Commands;
using System.Windows.Input;
using TP.Views;

namespace TP.ViewModels
{
    public class HomePageViewModels : BindableBase
        {
            public HomePageViewModels()
            {
                _items = new ObservableCollection<Character>
                {
                    new Character("Goku", new Uri("pack://application:,,,/TP;component/Assets/sangoku.jpg"), "Race : Saïyens", "Description : C'est le héros de l'histoire. Il est né en 737 sur la planète Végéta. Il mesure 175cm pour 62 kg. C'est un Saïyen et son vrai nom est Kakarotto.  Fils de Berduck, Saïyen de second ordre, il a deux frères : Raditz et Thalès. Goku a été envoyé sur Terre dans un vaisseau spatial alors qu'il n'était qu'un bébé, avec pour mission d'éliminer tous les habitants de la planète bleue. Il est recueilli par Son Gohan, qui décide de l'adopter. Suite à un violent choc à la tête, Goku perd complètement la mémoire et devient un gentil garçon adorable. Une nuit de pleine lune, il se transforme en gorille géant et tue son grand-père adoptif. Plus tard, il rencontre Bulma qui l'entraîne dans la quête des Dragon Balls. C'est là que commencent ses aventures, et qu'il rencontre plusieurs ennemis et rivaux qui vont se joindre à lui par la suite, comme Krilin, Yamcha, TenShinHan Piccolo ou Végéta. Il participe plusieurs fois au Tenka-Ichi-Budokai qu'il remporte lors de sa 23è édition face à Piccolo. C'est à l'âge de 22 ans qu'il découvre ses propres origines en rencontrant Raditz. Par la suite, il affronte de nombreux adversaires, tels que Freezer, Cell et Boo.  Goku a épousé Chi-Chi avec qui il a eu deux enfants : Gohan et Goten. Depuis le mariage de Gohan et Videl, il a également une petite fille, Pan, qu'il adore par-dessus tout. Goku est incontestablement un vrai Saïyen : il adore les combats et ne rêve que de se mesurer à des adversaires toujours plus forts pour dépasser ses propres limites. C'est aussi un gros glouton. Goku a une peur bleue des pîqures et par extension des hôpitaux.", new Uri("pack://application:,,,/TP;component/Assets/sangokutransfo.jpg")),

                    new Character("Vegeta", new Uri("pack://application:,,,/TP;component/Assets/vegeta.png"), "Race : Saïyens", "Description : Fils du roi Végéta, il est le prince des Saïyens. Né en 732 sur la planète Végéta, il est tout de suite remarqué par Freezer pour ses aptitudes exceptionnelles au combat. C'est entres autres pourquoi il est épargné de la destruction de la planète Végéta. Il est assisté et servi par Nappa, qui exécute le plus souvent ses sales besognes. Après la mort de Raditz, il se rend sur Terre afin de récupérer les Dragon Balls. C'est là qu'il subit une cuisante défaite contre Goku et ses amis. Il décide alors de partir sur Namek pour chercher d'autres Dragon Balls afin d'obtenir la vie éternelle. En effet, il souhaite vaincre Freezer et gouverner l'univers à sa place. Après de nombreuses péripéties, il est tué par Freezer mais ressuscite en même temps que ses autres victimes grâce aux Dragon Balls. Par la suite, la principale obsession de Végéta sera de dépasser Goku, son éternel rival qui a toujours une longueur d'avance. Même s'il devient un Super Saïyen, et qu'il affronte avec courage les cyborgs et Cell, Goku est toujours devant lui. Lors de l'apparition de Boo, Végéta se laisse volontairement posséder par Babidi pour devenir un peu plus fort et égaler enfin Goku. Ils ne vont pas jusqu'au bout de leur combat car Végéta prend conscience de ses erreurs et se sacrifie pour tenter en vain de tuer Boo. Lors du combat final, il accepte de fusionner avec Goku pour devenir Végéto, et c'est également lui qui a l'idée d'utiliser le Genkidama. Végéta est extrêmement orgueilleux et fier, et son unique but est de vaincre Goku. Son côté tyrannique et malfaisant s'est estompé petit à petit au contact des terriens. Il a fondé une famille avec Bulma et a eu deux enfants : Trunks et Bra.", new Uri("pack://application:,,,/TP;component/Assets/vegetatransfo.jpg")),

                    new Character("Beerus", new Uri("pack://application:,,,/TP;component/Assets/beerus.jpg"), "Race : Inconnu", "Description : Il est mince, avec de grandes oreilles pointues, semblables à un Cornish Rex et aux chats sphinx. Sa tenue est noire et bleue. Il semble être un fin gourmet, et son temple est rempli de poissons et d'autres aliments. Alors qu'il est un dieu redoutable, ses expressions faciales le font séparer de la plupart des antagonistes maléfiques de la série. Cependant, il est très facilement colérique sur des détails pourtant anecdotiques, comme sur un pudding. Il est très confiant sur sa puissance et il s'avère être l’adversaire le plus puissant rencontré par les héros (il bat Goku en SSJ3 en le frappant d'un faible coup à la nuque).", new Uri("pack://application:,,,/TP;component/Assets/beerustransfo.jpg")),
                };

                _deleteCharacterCommand = new DelegateCommand(ExecuteDeleteCharacter, CanDeleteCharacter);
                _createCharacterCommand = new DelegateCommand(ExecuteCreateCharacter);
            }

                
        

            private readonly ObservableCollection<Character> _items;
            /// <summary>
            /// Gets the items for this view model
            /// </summary>
            public IEnumerable<Character> Items
            {
                get { return _items; }
            }

            private Character _selectedCharacter;
            /// <summary>
            /// Gets or sets the selected character
            /// </summary>
            public Character SelectedCharacter
            {
                get { return _selectedCharacter; }
                set
                {
                    _selectedCharacter = value;
                    OnPropertyChanged(() => SelectedCharacter);
                    _deleteCharacterCommand.RaiseCanExecuteChanged();
                }
            }

            private readonly DelegateCommand _deleteCharacterCommand;
            /// <summary>
            /// Gets the delete character command
            /// </summary>
            public ICommand DeleteCharacterCommand
            {
                get { return _deleteCharacterCommand; }
            }

            private readonly DelegateCommand _createCharacterCommand;
            /// <summary>
            /// Gets the modification character command
            /// </summary>
            public ICommand CreateCharacterCommand
            {
                get { return _createCharacterCommand; }
            }

            /// <summary>
            /// Delete the character
            /// </summary>
            private void ExecuteDeleteCharacter()
            {
                _items.Remove(SelectedCharacter);
            }

            /// <summary>
            /// Check if we can delete a character
            /// </summary>
            /// <returns>True if we can, else false</returns>
            private bool CanDeleteCharacter()
            {
                return _selectedCharacter != null;
            }

            /// <summary>
            /// Create a character
            /// </summary>
            private void ExecuteCreateCharacter()
            {
                var character = new Character (string.Empty, null ,string.Empty, string.Empty, null);
                var createPage = new ModifPage(character);

                createPage.ShowDialog();

                if (!string.IsNullOrEmpty(character.Name))
                {
                    _items.Add(character);
                }
            }
        }
    }

