using System.ComponentModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using Prism.Commands;
using WolvenKit.Common;

namespace WolvenKit.Models
{
    public class SearchParameters : ObservableObject
    {
        #region Constructors

        public SearchParameters()
        {
            CaseSensitiveCommand = new DelegateCommand(CaseSensitive);
            WholeWordCommand = new DelegateCommand(WholeWord);
            RegexCommand = new DelegateCommand(Regex);
        }

        #endregion Constructors

        #region Properties

        public ICommand CaseSensitiveCommand { get; }
        public ICommand RegexCommand { get; }
        public ICommand WholeWordCommand { get; }

        #endregion Properties

        #region SearchText

        private string? _searchText;

        public string? SearchText
        {
            get => _searchText;
            set
            {
                if (_searchText != value)
                {
                    _searchText = value;
                    OnPropertyChanged("SearchParams");
                }
            }
        }

        #endregion SearchText

        #region SearchBundleText

        private string? _searchBundleText;

        public string? SearchBundleText
        {
            get => _searchBundleText;
            set
            {
                if (_searchBundleText != value)
                {
                    _searchBundleText = value;
                    OnPropertyChanged("SearchParams");
                }
            }
        }

        #endregion SearchBundleText

        #region SearchTypeText

        private string? _searchTypeText;

        public string? SearchTypeText
        {
            get => _searchTypeText;
            set
            {
                if (_searchTypeText != value)
                {
                    _searchTypeText = value;
                    OnPropertyChanged("SearchParams");
                }
            }
        }

        #endregion SearchTypeText

        #region IsRegex

        private bool _isRegex;

        public bool IsRegex
        {
            get => _isRegex;
            set
            {
                if (_isRegex != value)
                {
                    _isRegex = value;
                    OnPropertyChanged("SearchParams");
                }
            }
        }

        #endregion IsRegex

        #region IsWholeWord

        private bool _isWholeWord;

        public bool IsWholeWord
        {
            get => _isWholeWord;
            set
            {
                if (_isWholeWord != value)
                {
                    _isWholeWord = value;
                    OnPropertyChanged("SearchParams");
                }
            }
        }

        #endregion IsWholeWord

        #region IsMatchCase

        private bool _isMatchCase;

        public bool IsMatchCase
        {
            get => _isMatchCase;
            set
            {
                if (_isMatchCase != value)
                {
                    _isMatchCase = value;
                    OnPropertyChanged("SearchParams");
                }
            }
        }

        #endregion IsMatchCase

        #region IsCurrentFolder

        private bool _isCurrentFolder;

        public bool IsCurrentFolder
        {
            get => _isCurrentFolder;
            set
            {
                if (_isCurrentFolder != value)
                {
                    _isCurrentFolder = value;
                    OnPropertyChanged("SearchParams");
                }
            }
        }

        #endregion IsCurrentFolder

        #region IsRoot

        private bool _isRoot;

        public bool IsRoot
        {
            get => _isRoot;
            set
            {
                if (_isRoot != value)
                {
                    _isRoot = value;
                    OnPropertyChanged("SearchParams");
                }
            }
        }

        #endregion IsRoot

        #region IsAllSubfolders

        private bool _isAllSubfolders;

        public bool IsAllSubfolders
        {
            get => _isAllSubfolders;
            set
            {
                if (_isAllSubfolders != value)
                {
                    _isAllSubfolders = value;
                    OnPropertyChanged("SearchParams");
                }
            }
        }

        #endregion IsAllSubfolders

        #region Methods

        protected void CaseSensitive() => IsMatchCase = !IsMatchCase;

        protected void Regex() => IsRegex = !IsRegex;

        protected void WholeWord() => IsWholeWord = !IsWholeWord;

        #endregion Methods
    }
}
