using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimFeatureEntry : RedBaseClass
	{
		private CName _name;
		private CName _className;
		private CBool _forceAllocate;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("className")] 
		public CName ClassName
		{
			get => GetProperty(ref _className);
			set => SetProperty(ref _className, value);
		}

		[Ordinal(2)] 
		[RED("forceAllocate")] 
		public CBool ForceAllocate
		{
			get => GetProperty(ref _forceAllocate);
			set => SetProperty(ref _forceAllocate, value);
		}
	}
}
