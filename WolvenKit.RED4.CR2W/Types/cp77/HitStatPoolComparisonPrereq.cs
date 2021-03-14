using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HitStatPoolComparisonPrereq : GenericHitPrereq
	{
		private CString _comparisonSource;
		private CString _comparisonTarget;
		private CEnum<EComparisonType> _comparisonType;
		private CEnum<gamedataStatPoolType> _statPoolToCompare;

		[Ordinal(5)] 
		[RED("comparisonSource")] 
		public CString ComparisonSource
		{
			get
			{
				if (_comparisonSource == null)
				{
					_comparisonSource = (CString) CR2WTypeManager.Create("String", "comparisonSource", cr2w, this);
				}
				return _comparisonSource;
			}
			set
			{
				if (_comparisonSource == value)
				{
					return;
				}
				_comparisonSource = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("comparisonTarget")] 
		public CString ComparisonTarget
		{
			get
			{
				if (_comparisonTarget == null)
				{
					_comparisonTarget = (CString) CR2WTypeManager.Create("String", "comparisonTarget", cr2w, this);
				}
				return _comparisonTarget;
			}
			set
			{
				if (_comparisonTarget == value)
				{
					return;
				}
				_comparisonTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("comparisonType")] 
		public CEnum<EComparisonType> ComparisonType
		{
			get
			{
				if (_comparisonType == null)
				{
					_comparisonType = (CEnum<EComparisonType>) CR2WTypeManager.Create("EComparisonType", "comparisonType", cr2w, this);
				}
				return _comparisonType;
			}
			set
			{
				if (_comparisonType == value)
				{
					return;
				}
				_comparisonType = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("statPoolToCompare")] 
		public CEnum<gamedataStatPoolType> StatPoolToCompare
		{
			get
			{
				if (_statPoolToCompare == null)
				{
					_statPoolToCompare = (CEnum<gamedataStatPoolType>) CR2WTypeManager.Create("gamedataStatPoolType", "statPoolToCompare", cr2w, this);
				}
				return _statPoolToCompare;
			}
			set
			{
				if (_statPoolToCompare == value)
				{
					return;
				}
				_statPoolToCompare = value;
				PropertySet(this);
			}
		}

		public HitStatPoolComparisonPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
