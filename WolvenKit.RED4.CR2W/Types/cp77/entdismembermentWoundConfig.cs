using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entdismembermentWoundConfig : ISerializable
	{
		private CName _woundName;
		private CEnum<entdismembermentResourceSetE> _resourceSet;

		[Ordinal(0)] 
		[RED("WoundName")] 
		public CName WoundName
		{
			get => GetProperty(ref _woundName);
			set => SetProperty(ref _woundName, value);
		}

		[Ordinal(1)] 
		[RED("ResourceSet")] 
		public CEnum<entdismembermentResourceSetE> ResourceSet
		{
			get => GetProperty(ref _resourceSet);
			set => SetProperty(ref _resourceSet, value);
		}

		public entdismembermentWoundConfig(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
