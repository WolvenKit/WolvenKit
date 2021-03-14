using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCurveStatModifierData : gameStatModifierData
	{
		private CName _curveName;
		private CName _columnName;
		private CEnum<gamedataStatType> _curveStat;

		[Ordinal(2)] 
		[RED("curveName")] 
		public CName CurveName
		{
			get
			{
				if (_curveName == null)
				{
					_curveName = (CName) CR2WTypeManager.Create("CName", "curveName", cr2w, this);
				}
				return _curveName;
			}
			set
			{
				if (_curveName == value)
				{
					return;
				}
				_curveName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("columnName")] 
		public CName ColumnName
		{
			get
			{
				if (_columnName == null)
				{
					_columnName = (CName) CR2WTypeManager.Create("CName", "columnName", cr2w, this);
				}
				return _columnName;
			}
			set
			{
				if (_columnName == value)
				{
					return;
				}
				_columnName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("curveStat")] 
		public CEnum<gamedataStatType> CurveStat
		{
			get
			{
				if (_curveStat == null)
				{
					_curveStat = (CEnum<gamedataStatType>) CR2WTypeManager.Create("gamedataStatType", "curveStat", cr2w, this);
				}
				return _curveStat;
			}
			set
			{
				if (_curveStat == value)
				{
					return;
				}
				_curveStat = value;
				PropertySet(this);
			}
		}

		public gameCurveStatModifierData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
