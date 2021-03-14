using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OnProgressBarAnimFinish : redEvent
	{
		private CFloat _fullbarSize;
		private CBool _isNegative;

		[Ordinal(0)] 
		[RED("FullbarSize")] 
		public CFloat FullbarSize
		{
			get
			{
				if (_fullbarSize == null)
				{
					_fullbarSize = (CFloat) CR2WTypeManager.Create("Float", "FullbarSize", cr2w, this);
				}
				return _fullbarSize;
			}
			set
			{
				if (_fullbarSize == value)
				{
					return;
				}
				_fullbarSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("IsNegative")] 
		public CBool IsNegative
		{
			get
			{
				if (_isNegative == null)
				{
					_isNegative = (CBool) CR2WTypeManager.Create("Bool", "IsNegative", cr2w, this);
				}
				return _isNegative;
			}
			set
			{
				if (_isNegative == value)
				{
					return;
				}
				_isNegative = value;
				PropertySet(this);
			}
		}

		public OnProgressBarAnimFinish(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
