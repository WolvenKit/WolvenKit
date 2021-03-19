using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameContainerObjectAnimated : gameContainerObjectBase
	{
		private CName _animFeatureName;

		[Ordinal(51)] 
		[RED("animFeatureName")] 
		public CName AnimFeatureName
		{
			get => GetProperty(ref _animFeatureName);
			set => SetProperty(ref _animFeatureName, value);
		}

		public gameContainerObjectAnimated(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
