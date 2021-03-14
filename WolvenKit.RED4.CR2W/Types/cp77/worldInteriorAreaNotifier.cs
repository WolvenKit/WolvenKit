using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldInteriorAreaNotifier : worldITriggerAreaNotifer
	{
		private CArray<TweakDBID> _gameRestrictionIDs;
		private CBool _treatAsInterior;
		private CBool _setTier2;

		[Ordinal(3)] 
		[RED("gameRestrictionIDs")] 
		public CArray<TweakDBID> GameRestrictionIDs
		{
			get
			{
				if (_gameRestrictionIDs == null)
				{
					_gameRestrictionIDs = (CArray<TweakDBID>) CR2WTypeManager.Create("array:TweakDBID", "gameRestrictionIDs", cr2w, this);
				}
				return _gameRestrictionIDs;
			}
			set
			{
				if (_gameRestrictionIDs == value)
				{
					return;
				}
				_gameRestrictionIDs = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("treatAsInterior")] 
		public CBool TreatAsInterior
		{
			get
			{
				if (_treatAsInterior == null)
				{
					_treatAsInterior = (CBool) CR2WTypeManager.Create("Bool", "treatAsInterior", cr2w, this);
				}
				return _treatAsInterior;
			}
			set
			{
				if (_treatAsInterior == value)
				{
					return;
				}
				_treatAsInterior = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("setTier2")] 
		public CBool SetTier2
		{
			get
			{
				if (_setTier2 == null)
				{
					_setTier2 = (CBool) CR2WTypeManager.Create("Bool", "setTier2", cr2w, this);
				}
				return _setTier2;
			}
			set
			{
				if (_setTier2 == value)
				{
					return;
				}
				_setTier2 = value;
				PropertySet(this);
			}
		}

		public worldInteriorAreaNotifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
