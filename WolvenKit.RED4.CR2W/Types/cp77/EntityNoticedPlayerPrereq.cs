using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EntityNoticedPlayerPrereq : gameIScriptablePrereq
	{
		private CBool _isPlayerNoticed;
		private CUInt32 _valueToListen;

		[Ordinal(0)] 
		[RED("isPlayerNoticed")] 
		public CBool IsPlayerNoticed
		{
			get
			{
				if (_isPlayerNoticed == null)
				{
					_isPlayerNoticed = (CBool) CR2WTypeManager.Create("Bool", "isPlayerNoticed", cr2w, this);
				}
				return _isPlayerNoticed;
			}
			set
			{
				if (_isPlayerNoticed == value)
				{
					return;
				}
				_isPlayerNoticed = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("valueToListen")] 
		public CUInt32 ValueToListen
		{
			get
			{
				if (_valueToListen == null)
				{
					_valueToListen = (CUInt32) CR2WTypeManager.Create("Uint32", "valueToListen", cr2w, this);
				}
				return _valueToListen;
			}
			set
			{
				if (_valueToListen == value)
				{
					return;
				}
				_valueToListen = value;
				PropertySet(this);
			}
		}

		public EntityNoticedPlayerPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
