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
			get
			{
				if (_interactionTag == null)
				{
					_interactionTag = (CName) CR2WTypeManager.Create("CName", "interactionTag", cr2w, this);
				}
				return _interactionTag;
			}
			set
			{
				if (_interactionTag == value)
				{
					return;
				}
				_interactionTag = value;
				PropertySet(this);
			}
		}

		public gamePickupObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
