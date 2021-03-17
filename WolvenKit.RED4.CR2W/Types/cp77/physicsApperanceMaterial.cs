using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsApperanceMaterial : CVariable
	{
		private CName _apperanceName;
		private CName _materialFrom;
		private CName _material;

		[Ordinal(0)] 
		[RED("apperanceName")] 
		public CName ApperanceName
		{
			get => GetProperty(ref _apperanceName);
			set => SetProperty(ref _apperanceName, value);
		}

		[Ordinal(1)] 
		[RED("materialFrom")] 
		public CName MaterialFrom
		{
			get => GetProperty(ref _materialFrom);
			set => SetProperty(ref _materialFrom, value);
		}

		[Ordinal(2)] 
		[RED("material")] 
		public CName Material
		{
			get => GetProperty(ref _material);
			set => SetProperty(ref _material, value);
		}

		public physicsApperanceMaterial(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
