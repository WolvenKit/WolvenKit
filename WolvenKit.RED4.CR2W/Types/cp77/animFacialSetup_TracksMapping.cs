using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animFacialSetup_TracksMapping : CVariable
	{
		private CUInt16 _numEnvelopes;
		private CUInt16 _numMainPoses;
		private CUInt16 _numLipsyncOverrides;
		private CUInt16 _numWrinkles;

		[Ordinal(0)] 
		[RED("numEnvelopes")] 
		public CUInt16 NumEnvelopes
		{
			get
			{
				if (_numEnvelopes == null)
				{
					_numEnvelopes = (CUInt16) CR2WTypeManager.Create("Uint16", "numEnvelopes", cr2w, this);
				}
				return _numEnvelopes;
			}
			set
			{
				if (_numEnvelopes == value)
				{
					return;
				}
				_numEnvelopes = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("numMainPoses")] 
		public CUInt16 NumMainPoses
		{
			get
			{
				if (_numMainPoses == null)
				{
					_numMainPoses = (CUInt16) CR2WTypeManager.Create("Uint16", "numMainPoses", cr2w, this);
				}
				return _numMainPoses;
			}
			set
			{
				if (_numMainPoses == value)
				{
					return;
				}
				_numMainPoses = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("numLipsyncOverrides")] 
		public CUInt16 NumLipsyncOverrides
		{
			get
			{
				if (_numLipsyncOverrides == null)
				{
					_numLipsyncOverrides = (CUInt16) CR2WTypeManager.Create("Uint16", "numLipsyncOverrides", cr2w, this);
				}
				return _numLipsyncOverrides;
			}
			set
			{
				if (_numLipsyncOverrides == value)
				{
					return;
				}
				_numLipsyncOverrides = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("numWrinkles")] 
		public CUInt16 NumWrinkles
		{
			get
			{
				if (_numWrinkles == null)
				{
					_numWrinkles = (CUInt16) CR2WTypeManager.Create("Uint16", "numWrinkles", cr2w, this);
				}
				return _numWrinkles;
			}
			set
			{
				if (_numWrinkles == value)
				{
					return;
				}
				_numWrinkles = value;
				PropertySet(this);
			}
		}

		public animFacialSetup_TracksMapping(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
