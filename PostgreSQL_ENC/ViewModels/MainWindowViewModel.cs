using PostgreSQL_ENC.Models.Base;
using PostgreSQL_ENC.ViewModels.Base;

namespace PostgreSQL_ENC.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        #region Заголовок окна
        private string _Title = "Students";
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }
        #endregion
        public MainWindowViewModel()
        {
            using (Context context = new Context())
            {

            }
        }
    }
}
