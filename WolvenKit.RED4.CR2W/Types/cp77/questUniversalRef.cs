using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questUniversalRef : ISerializable
	{
		private gameEntityReference _entityReference;
		private CBool _refLocalPlayer;
		private CBool _mainPlayerObject;

		[Ordinal(0)] 
		[RED("entityReference")] 
		public gameEntityReference EntityReference
		{
			get
			{
				if (_entityReference == null)
				{
					_entityReference = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "entityReference", cr2w, this);
				}
				return _entityReference;
			}
			set
			{
				if (_entityReference == value)
				{
					return;
				}
				_entityReference = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("refLocalPlayer")] 
		public CBool RefLocalPlayer
		{
			get
			{
				if (_refLocalPlayer == null)
				{
					_refLocalPlayer = (CBool) CR2WTypeManager.Create("Bool", "refLocalPlayer", cr2w, this);
				}
				return _refLocalPlayer;
			}
			set
			{
				if (_refLocalPlayer == value)
				{
					return;
				}
				_refLocalPlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("mainPlayerObject")] 
		public CBool MainPlayerObject
		{
			get
			{
				if (_mainPlayerObject == null)
				{
					_mainPlayerObject = (CBool) CR2WTypeManager.Create("Bool", "mainPlayerObject", cr2w, this);
				}
				return _mainPlayerObject;
			}
			set
			{
				if (_mainPlayerObject == value)
				{
					return;
				}
				_mainPlayerObject = value;
				PropertySet(this);
			}
		}

		public questUniversalRef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
