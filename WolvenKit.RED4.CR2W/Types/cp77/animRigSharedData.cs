using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animRigSharedData : CResource
	{
		private CArray<animRigPart> _parts;
		private CArray<CHandle<animIRigIkSetup>> _ikSetups;

		[Ordinal(1)] 
		[RED("parts")] 
		public CArray<animRigPart> Parts
		{
			get => GetProperty(ref _parts);
			set => SetProperty(ref _parts, value);
		}

		[Ordinal(2)] 
		[RED("ikSetups")] 
		public CArray<CHandle<animIRigIkSetup>> IkSetups
		{
			get => GetProperty(ref _ikSetups);
			set => SetProperty(ref _ikSetups, value);
		}

		public animRigSharedData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
