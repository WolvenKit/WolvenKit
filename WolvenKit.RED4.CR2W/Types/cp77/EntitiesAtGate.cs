using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EntitiesAtGate : MorphData
	{
		private CArray<entEntityID> _entitiesAtGate;

		[Ordinal(1)] 
		[RED("entitiesAtGate")] 
		public CArray<entEntityID> EntitiesAtGate_
		{
			get => GetProperty(ref _entitiesAtGate);
			set => SetProperty(ref _entitiesAtGate, value);
		}

		public EntitiesAtGate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
