using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetGlobalTvOnly : redEvent
	{
		private CBool _isGlobalTvOnly;

		[Ordinal(0)] 
		[RED("isGlobalTvOnly")] 
		public CBool IsGlobalTvOnly
		{
			get
			{
				if (_isGlobalTvOnly == null)
				{
					_isGlobalTvOnly = (CBool) CR2WTypeManager.Create("Bool", "isGlobalTvOnly", cr2w, this);
				}
				return _isGlobalTvOnly;
			}
			set
			{
				if (_isGlobalTvOnly == value)
				{
					return;
				}
				_isGlobalTvOnly = value;
				PropertySet(this);
			}
		}

		public SetGlobalTvOnly(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
