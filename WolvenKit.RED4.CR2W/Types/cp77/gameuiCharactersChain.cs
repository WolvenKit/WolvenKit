using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCharactersChain : CVariable
	{
		private CArray<CUInt32> _rarities;
		private CUInt32 _matchedValues;
		private CInt32 _ownerId;
		private CBool _isFulfilled;
		private CBool _isPossible;

		[Ordinal(0)] 
		[RED("rarities")] 
		public CArray<CUInt32> Rarities
		{
			get
			{
				if (_rarities == null)
				{
					_rarities = (CArray<CUInt32>) CR2WTypeManager.Create("array:Uint32", "rarities", cr2w, this);
				}
				return _rarities;
			}
			set
			{
				if (_rarities == value)
				{
					return;
				}
				_rarities = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("matchedValues")] 
		public CUInt32 MatchedValues
		{
			get
			{
				if (_matchedValues == null)
				{
					_matchedValues = (CUInt32) CR2WTypeManager.Create("Uint32", "matchedValues", cr2w, this);
				}
				return _matchedValues;
			}
			set
			{
				if (_matchedValues == value)
				{
					return;
				}
				_matchedValues = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("ownerId")] 
		public CInt32 OwnerId
		{
			get
			{
				if (_ownerId == null)
				{
					_ownerId = (CInt32) CR2WTypeManager.Create("Int32", "ownerId", cr2w, this);
				}
				return _ownerId;
			}
			set
			{
				if (_ownerId == value)
				{
					return;
				}
				_ownerId = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isFulfilled")] 
		public CBool IsFulfilled
		{
			get
			{
				if (_isFulfilled == null)
				{
					_isFulfilled = (CBool) CR2WTypeManager.Create("Bool", "isFulfilled", cr2w, this);
				}
				return _isFulfilled;
			}
			set
			{
				if (_isFulfilled == value)
				{
					return;
				}
				_isFulfilled = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("isPossible")] 
		public CBool IsPossible
		{
			get
			{
				if (_isPossible == null)
				{
					_isPossible = (CBool) CR2WTypeManager.Create("Bool", "isPossible", cr2w, this);
				}
				return _isPossible;
			}
			set
			{
				if (_isPossible == value)
				{
					return;
				}
				_isPossible = value;
				PropertySet(this);
			}
		}

		public gameuiCharactersChain(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
