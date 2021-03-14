using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineparameterTypeInteractionDescription : IScriptable
	{
		private wCHandle<entEntity> _interactionEntity;
		private CName _interactionType;

		[Ordinal(0)] 
		[RED("interactionEntity")] 
		public wCHandle<entEntity> InteractionEntity
		{
			get
			{
				if (_interactionEntity == null)
				{
					_interactionEntity = (wCHandle<entEntity>) CR2WTypeManager.Create("whandle:entEntity", "interactionEntity", cr2w, this);
				}
				return _interactionEntity;
			}
			set
			{
				if (_interactionEntity == value)
				{
					return;
				}
				_interactionEntity = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("interactionType")] 
		public CName InteractionType
		{
			get
			{
				if (_interactionType == null)
				{
					_interactionType = (CName) CR2WTypeManager.Create("CName", "interactionType", cr2w, this);
				}
				return _interactionType;
			}
			set
			{
				if (_interactionType == value)
				{
					return;
				}
				_interactionType = value;
				PropertySet(this);
			}
		}

		public gamestateMachineparameterTypeInteractionDescription(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
