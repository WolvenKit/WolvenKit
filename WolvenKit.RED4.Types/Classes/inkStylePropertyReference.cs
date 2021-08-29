using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkStylePropertyReference : RedBaseClass
	{
		private CName _referencedPath;

		[Ordinal(0)] 
		[RED("referencedPath")] 
		public CName ReferencedPath
		{
			get => GetProperty(ref _referencedPath);
			set => SetProperty(ref _referencedPath, value);
		}
	}
}
