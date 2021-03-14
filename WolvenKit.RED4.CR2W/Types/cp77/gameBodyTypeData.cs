using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameBodyTypeData : CVariable
	{
		private CUInt64 _rigHash;
		private CArray<CUInt64> _animsetHashes;
		private CArray<gameAnimsetOverrideData> _overrides;

		[Ordinal(0)] 
		[RED("rigHash")] 
		public CUInt64 RigHash
		{
			get
			{
				if (_rigHash == null)
				{
					_rigHash = (CUInt64) CR2WTypeManager.Create("Uint64", "rigHash", cr2w, this);
				}
				return _rigHash;
			}
			set
			{
				if (_rigHash == value)
				{
					return;
				}
				_rigHash = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("animsetHashes")] 
		public CArray<CUInt64> AnimsetHashes
		{
			get
			{
				if (_animsetHashes == null)
				{
					_animsetHashes = (CArray<CUInt64>) CR2WTypeManager.Create("array:Uint64", "animsetHashes", cr2w, this);
				}
				return _animsetHashes;
			}
			set
			{
				if (_animsetHashes == value)
				{
					return;
				}
				_animsetHashes = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("overrides")] 
		public CArray<gameAnimsetOverrideData> Overrides
		{
			get
			{
				if (_overrides == null)
				{
					_overrides = (CArray<gameAnimsetOverrideData>) CR2WTypeManager.Create("array:gameAnimsetOverrideData", "overrides", cr2w, this);
				}
				return _overrides;
			}
			set
			{
				if (_overrides == value)
				{
					return;
				}
				_overrides = value;
				PropertySet(this);
			}
		}

		public gameBodyTypeData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
