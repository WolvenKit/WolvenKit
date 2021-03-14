using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameDebugCheatsSharedState : gameIGameSystemReplicatedState
	{
		private CArray<gamecheatsystemObjCheats> _activeCheats;
		private CUInt32 _debugTimeDilationIndex;
		private CUInt32 _debugTimeDilationPlayerIndex;

		[Ordinal(0)] 
		[RED("activeCheats")] 
		public CArray<gamecheatsystemObjCheats> ActiveCheats
		{
			get
			{
				if (_activeCheats == null)
				{
					_activeCheats = (CArray<gamecheatsystemObjCheats>) CR2WTypeManager.Create("array:gamecheatsystemObjCheats", "activeCheats", cr2w, this);
				}
				return _activeCheats;
			}
			set
			{
				if (_activeCheats == value)
				{
					return;
				}
				_activeCheats = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("debugTimeDilationIndex")] 
		public CUInt32 DebugTimeDilationIndex
		{
			get
			{
				if (_debugTimeDilationIndex == null)
				{
					_debugTimeDilationIndex = (CUInt32) CR2WTypeManager.Create("Uint32", "debugTimeDilationIndex", cr2w, this);
				}
				return _debugTimeDilationIndex;
			}
			set
			{
				if (_debugTimeDilationIndex == value)
				{
					return;
				}
				_debugTimeDilationIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("debugTimeDilationPlayerIndex")] 
		public CUInt32 DebugTimeDilationPlayerIndex
		{
			get
			{
				if (_debugTimeDilationPlayerIndex == null)
				{
					_debugTimeDilationPlayerIndex = (CUInt32) CR2WTypeManager.Create("Uint32", "debugTimeDilationPlayerIndex", cr2w, this);
				}
				return _debugTimeDilationPlayerIndex;
			}
			set
			{
				if (_debugTimeDilationPlayerIndex == value)
				{
					return;
				}
				_debugTimeDilationPlayerIndex = value;
				PropertySet(this);
			}
		}

		public gameDebugCheatsSharedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
