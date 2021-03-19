using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePickupObject : gameObject
	{
		private CName _interactionTag;

		[Ordinal(40)] 
		[RED("interactionTag")] 
		public CName InteractionTag
		{
			get => GetProperty(ref _interactionTag);
			set => SetProperty(ref _interactionTag, value);
		}

		public gamePickupObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
