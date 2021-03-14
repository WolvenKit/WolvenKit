using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UIBuffInfo : gameuiBuffInfo
	{
		private CBool _isBuff;
		private CUInt32 _stackCount;

		[Ordinal(2)] 
		[RED("isBuff")] 
		public CBool IsBuff
		{
			get
			{
				if (_isBuff == null)
				{
					_isBuff = (CBool) CR2WTypeManager.Create("Bool", "isBuff", cr2w, this);
				}
				return _isBuff;
			}
			set
			{
				if (_isBuff == value)
				{
					return;
				}
				_isBuff = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("stackCount")] 
		public CUInt32 StackCount
		{
			get
			{
				if (_stackCount == null)
				{
					_stackCount = (CUInt32) CR2WTypeManager.Create("Uint32", "stackCount", cr2w, this);
				}
				return _stackCount;
			}
			set
			{
				if (_stackCount == value)
				{
					return;
				}
				_stackCount = value;
				PropertySet(this);
			}
		}

		public UIBuffInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
