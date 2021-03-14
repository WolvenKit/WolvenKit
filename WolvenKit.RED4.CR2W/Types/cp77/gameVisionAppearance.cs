using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameVisionAppearance : CVariable
	{
		private CInt32 _fill;
		private CInt32 _outline;
		private CBool _showThroughWalls;
		private CEnum<gameVisionModePatternType> _patternType;

		[Ordinal(0)] 
		[RED("fill")] 
		public CInt32 Fill
		{
			get
			{
				if (_fill == null)
				{
					_fill = (CInt32) CR2WTypeManager.Create("Int32", "fill", cr2w, this);
				}
				return _fill;
			}
			set
			{
				if (_fill == value)
				{
					return;
				}
				_fill = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("outline")] 
		public CInt32 Outline
		{
			get
			{
				if (_outline == null)
				{
					_outline = (CInt32) CR2WTypeManager.Create("Int32", "outline", cr2w, this);
				}
				return _outline;
			}
			set
			{
				if (_outline == value)
				{
					return;
				}
				_outline = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("showThroughWalls")] 
		public CBool ShowThroughWalls
		{
			get
			{
				if (_showThroughWalls == null)
				{
					_showThroughWalls = (CBool) CR2WTypeManager.Create("Bool", "showThroughWalls", cr2w, this);
				}
				return _showThroughWalls;
			}
			set
			{
				if (_showThroughWalls == value)
				{
					return;
				}
				_showThroughWalls = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("patternType")] 
		public CEnum<gameVisionModePatternType> PatternType
		{
			get
			{
				if (_patternType == null)
				{
					_patternType = (CEnum<gameVisionModePatternType>) CR2WTypeManager.Create("gameVisionModePatternType", "patternType", cr2w, this);
				}
				return _patternType;
			}
			set
			{
				if (_patternType == value)
				{
					return;
				}
				_patternType = value;
				PropertySet(this);
			}
		}

		public gameVisionAppearance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
