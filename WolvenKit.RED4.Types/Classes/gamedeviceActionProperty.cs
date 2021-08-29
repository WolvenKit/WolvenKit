using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedeviceActionProperty : IScriptable
	{
		private CName _name;
		private CName _typeName;
		private CVariant _first;
		private CVariant _second;
		private CVariant _third;
		private CEnum<gamedeviceActionPropertyFlags> _flags;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("typeName")] 
		public CName TypeName
		{
			get => GetProperty(ref _typeName);
			set => SetProperty(ref _typeName, value);
		}

		[Ordinal(2)] 
		[RED("first")] 
		public CVariant First
		{
			get => GetProperty(ref _first);
			set => SetProperty(ref _first, value);
		}

		[Ordinal(3)] 
		[RED("second")] 
		public CVariant Second
		{
			get => GetProperty(ref _second);
			set => SetProperty(ref _second, value);
		}

		[Ordinal(4)] 
		[RED("third")] 
		public CVariant Third
		{
			get => GetProperty(ref _third);
			set => SetProperty(ref _third, value);
		}

		[Ordinal(5)] 
		[RED("flags")] 
		public CEnum<gamedeviceActionPropertyFlags> Flags
		{
			get => GetProperty(ref _flags);
			set => SetProperty(ref _flags, value);
		}
	}
}
