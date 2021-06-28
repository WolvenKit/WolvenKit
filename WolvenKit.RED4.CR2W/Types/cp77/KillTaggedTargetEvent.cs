using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class KillTaggedTargetEvent : redEvent
	{
		private wCHandle<gameObject> _taggedObject;

		[Ordinal(0)] 
		[RED("taggedObject")] 
		public wCHandle<gameObject> TaggedObject
		{
			get => GetProperty(ref _taggedObject);
			set => SetProperty(ref _taggedObject, value);
		}

		public KillTaggedTargetEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
