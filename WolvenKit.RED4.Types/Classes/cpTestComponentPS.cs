using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class cpTestComponentPS : gameComponentPS
	{
		private CInt32 _something;
		private CBool _somethingNotInstanceEdiable;
		private CName _nameEditable;
		private CName _nameInstanceEditable;
		private CName _namePersistent;
		private CName _namePersistentEdiable;
		private CName _namePersistentInstanceEditable;

		[Ordinal(0)] 
		[RED("something")] 
		public CInt32 Something
		{
			get => GetProperty(ref _something);
			set => SetProperty(ref _something, value);
		}

		[Ordinal(1)] 
		[RED("somethingNotInstanceEdiable")] 
		public CBool SomethingNotInstanceEdiable
		{
			get => GetProperty(ref _somethingNotInstanceEdiable);
			set => SetProperty(ref _somethingNotInstanceEdiable, value);
		}

		[Ordinal(2)] 
		[RED("nameEditable")] 
		public CName NameEditable
		{
			get => GetProperty(ref _nameEditable);
			set => SetProperty(ref _nameEditable, value);
		}

		[Ordinal(3)] 
		[RED("nameInstanceEditable")] 
		public CName NameInstanceEditable
		{
			get => GetProperty(ref _nameInstanceEditable);
			set => SetProperty(ref _nameInstanceEditable, value);
		}

		[Ordinal(4)] 
		[RED("namePersistent")] 
		public CName NamePersistent
		{
			get => GetProperty(ref _namePersistent);
			set => SetProperty(ref _namePersistent, value);
		}

		[Ordinal(5)] 
		[RED("namePersistentEdiable")] 
		public CName NamePersistentEdiable
		{
			get => GetProperty(ref _namePersistentEdiable);
			set => SetProperty(ref _namePersistentEdiable, value);
		}

		[Ordinal(6)] 
		[RED("namePersistentInstanceEditable")] 
		public CName NamePersistentInstanceEditable
		{
			get => GetProperty(ref _namePersistentInstanceEditable);
			set => SetProperty(ref _namePersistentInstanceEditable, value);
		}

		public cpTestComponentPS()
		{
			_nameEditable = "E";
			_nameInstanceEditable = "IE";
			_namePersistent = "P";
			_namePersistentEdiable = "PE";
			_namePersistentInstanceEditable = "PIE";
		}
	}
}
