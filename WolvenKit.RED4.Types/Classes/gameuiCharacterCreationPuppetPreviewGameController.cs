using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiCharacterCreationPuppetPreviewGameController : gameuiPuppetPreviewGameController
	{
		private CName _maleSceneName;
		private CName _femaleSceneName;
		private NodeRef _maleCamera01Ref;
		private NodeRef _femaleCamera01Ref;
		private inkCompoundWidgetReference _root;
		private inkImageWidgetReference _image;
		private inkWidgetLibraryReference _animLib;
		private CName _animName;

		[Ordinal(8)] 
		[RED("maleSceneName")] 
		public CName MaleSceneName
		{
			get => GetProperty(ref _maleSceneName);
			set => SetProperty(ref _maleSceneName, value);
		}

		[Ordinal(9)] 
		[RED("femaleSceneName")] 
		public CName FemaleSceneName
		{
			get => GetProperty(ref _femaleSceneName);
			set => SetProperty(ref _femaleSceneName, value);
		}

		[Ordinal(10)] 
		[RED("maleCamera01Ref")] 
		public NodeRef MaleCamera01Ref
		{
			get => GetProperty(ref _maleCamera01Ref);
			set => SetProperty(ref _maleCamera01Ref, value);
		}

		[Ordinal(11)] 
		[RED("femaleCamera01Ref")] 
		public NodeRef FemaleCamera01Ref
		{
			get => GetProperty(ref _femaleCamera01Ref);
			set => SetProperty(ref _femaleCamera01Ref, value);
		}

		[Ordinal(12)] 
		[RED("root")] 
		public inkCompoundWidgetReference Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(13)] 
		[RED("image")] 
		public inkImageWidgetReference Image
		{
			get => GetProperty(ref _image);
			set => SetProperty(ref _image, value);
		}

		[Ordinal(14)] 
		[RED("animLib")] 
		public inkWidgetLibraryReference AnimLib
		{
			get => GetProperty(ref _animLib);
			set => SetProperty(ref _animLib, value);
		}

		[Ordinal(15)] 
		[RED("animName")] 
		public CName AnimName
		{
			get => GetProperty(ref _animName);
			set => SetProperty(ref _animName, value);
		}
	}
}
