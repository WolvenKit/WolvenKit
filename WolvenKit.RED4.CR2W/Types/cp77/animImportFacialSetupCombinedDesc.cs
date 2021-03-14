using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animImportFacialSetupCombinedDesc : CVariable
	{
		private animImportFacialSetupDesc _face;
		private animImportFacialSetupDesc _eyes;
		private animImportFacialSetupDesc _tongue;
		private CArray<CUInt16> _usedTransformIndices;
		private CArray<CInt16> _lipsyncOverrideToMainPosesTracksMapping;
		private CInt16 _firstLipsyncOverrideTrackIndex;

		[Ordinal(0)] 
		[RED("face")] 
		public animImportFacialSetupDesc Face
		{
			get
			{
				if (_face == null)
				{
					_face = (animImportFacialSetupDesc) CR2WTypeManager.Create("animImportFacialSetupDesc", "face", cr2w, this);
				}
				return _face;
			}
			set
			{
				if (_face == value)
				{
					return;
				}
				_face = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("eyes")] 
		public animImportFacialSetupDesc Eyes
		{
			get
			{
				if (_eyes == null)
				{
					_eyes = (animImportFacialSetupDesc) CR2WTypeManager.Create("animImportFacialSetupDesc", "eyes", cr2w, this);
				}
				return _eyes;
			}
			set
			{
				if (_eyes == value)
				{
					return;
				}
				_eyes = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("tongue")] 
		public animImportFacialSetupDesc Tongue
		{
			get
			{
				if (_tongue == null)
				{
					_tongue = (animImportFacialSetupDesc) CR2WTypeManager.Create("animImportFacialSetupDesc", "tongue", cr2w, this);
				}
				return _tongue;
			}
			set
			{
				if (_tongue == value)
				{
					return;
				}
				_tongue = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("usedTransformIndices")] 
		public CArray<CUInt16> UsedTransformIndices
		{
			get
			{
				if (_usedTransformIndices == null)
				{
					_usedTransformIndices = (CArray<CUInt16>) CR2WTypeManager.Create("array:Uint16", "usedTransformIndices", cr2w, this);
				}
				return _usedTransformIndices;
			}
			set
			{
				if (_usedTransformIndices == value)
				{
					return;
				}
				_usedTransformIndices = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("lipsyncOverrideToMainPosesTracksMapping")] 
		public CArray<CInt16> LipsyncOverrideToMainPosesTracksMapping
		{
			get
			{
				if (_lipsyncOverrideToMainPosesTracksMapping == null)
				{
					_lipsyncOverrideToMainPosesTracksMapping = (CArray<CInt16>) CR2WTypeManager.Create("array:Int16", "lipsyncOverrideToMainPosesTracksMapping", cr2w, this);
				}
				return _lipsyncOverrideToMainPosesTracksMapping;
			}
			set
			{
				if (_lipsyncOverrideToMainPosesTracksMapping == value)
				{
					return;
				}
				_lipsyncOverrideToMainPosesTracksMapping = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("firstLipsyncOverrideTrackIndex")] 
		public CInt16 FirstLipsyncOverrideTrackIndex
		{
			get
			{
				if (_firstLipsyncOverrideTrackIndex == null)
				{
					_firstLipsyncOverrideTrackIndex = (CInt16) CR2WTypeManager.Create("Int16", "firstLipsyncOverrideTrackIndex", cr2w, this);
				}
				return _firstLipsyncOverrideTrackIndex;
			}
			set
			{
				if (_firstLipsyncOverrideTrackIndex == value)
				{
					return;
				}
				_firstLipsyncOverrideTrackIndex = value;
				PropertySet(this);
			}
		}

		public animImportFacialSetupCombinedDesc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
