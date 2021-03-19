using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FilterNPCsByType : gameEffectObjectSingleFilter_Scripted
	{
		private CArray<CEnum<gamedataNPCType>> _allowedTypes;
		private CBool _invert;

		[Ordinal(0)] 
		[RED("allowedTypes")] 
		public CArray<CEnum<gamedataNPCType>> AllowedTypes
		{
			get => GetProperty(ref _allowedTypes);
			set => SetProperty(ref _allowedTypes, value);
		}

		[Ordinal(1)] 
		[RED("invert")] 
		public CBool Invert
		{
			get => GetProperty(ref _invert);
			set => SetProperty(ref _invert, value);
		}

		public FilterNPCsByType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
