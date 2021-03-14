using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSpawnToken_NodeSubType : questIContentTokenManager_NodeSubType
	{
		private CBool _immediate;

		[Ordinal(0)] 
		[RED("immediate")] 
		public CBool Immediate
		{
			get
			{
				if (_immediate == null)
				{
					_immediate = (CBool) CR2WTypeManager.Create("Bool", "immediate", cr2w, this);
				}
				return _immediate;
			}
			set
			{
				if (_immediate == value)
				{
					return;
				}
				_immediate = value;
				PropertySet(this);
			}
		}

		public questSpawnToken_NodeSubType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
