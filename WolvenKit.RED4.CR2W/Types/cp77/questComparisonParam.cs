using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questComparisonParam : ISerializable
	{
		private CBool _entireCommunity;
		private CUInt32 _count;
		private CEnum<EComparisonType> _comparisonType;

		[Ordinal(0)] 
		[RED("entireCommunity")] 
		public CBool EntireCommunity
		{
			get
			{
				if (_entireCommunity == null)
				{
					_entireCommunity = (CBool) CR2WTypeManager.Create("Bool", "entireCommunity", cr2w, this);
				}
				return _entireCommunity;
			}
			set
			{
				if (_entireCommunity == value)
				{
					return;
				}
				_entireCommunity = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("count")] 
		public CUInt32 Count
		{
			get
			{
				if (_count == null)
				{
					_count = (CUInt32) CR2WTypeManager.Create("Uint32", "count", cr2w, this);
				}
				return _count;
			}
			set
			{
				if (_count == value)
				{
					return;
				}
				_count = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		public questComparisonParam(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
