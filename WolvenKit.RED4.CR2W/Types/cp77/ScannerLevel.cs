using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerLevel : ScannerChunk
	{
		private CInt32 _level;
		private CBool _isHard;

		[Ordinal(0)] 
		[RED("level")] 
		public CInt32 Level
		{
			get
			{
				if (_level == null)
				{
					_level = (CInt32) CR2WTypeManager.Create("Int32", "level", cr2w, this);
				}
				return _level;
			}
			set
			{
				if (_level == value)
				{
					return;
				}
				_level = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isHard")] 
		public CBool IsHard
		{
			get
			{
				if (_isHard == null)
				{
					_isHard = (CBool) CR2WTypeManager.Create("Bool", "isHard", cr2w, this);
				}
				return _isHard;
			}
			set
			{
				if (_isHard == value)
				{
					return;
				}
				_isHard = value;
				PropertySet(this);
			}
		}

		public ScannerLevel(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
