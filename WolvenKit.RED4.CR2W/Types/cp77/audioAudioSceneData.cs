using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAudioSceneData : audioAudioMetadata
	{
		private CArrayFixedSize<audioAudioStateData> _anyStateArray;
		private CArray<audioAudioStateData> _states;
		private CArray<audioAnyStateTransitionEntry> _anyStateTransitionsTable;
		private CArray<audioVoLineSignal> _voLineSignals;
		private CName _signalLeadingToShutdown;
		private CName _templateScene;
		private CArray<audioAudioSceneStateOverride> _templateSceneStateOverrides;
		private CArray<audioAudioSceneSignalOverride> _templateSceneSignalOverrides;

		[Ordinal(1)] 
		[RED("anyStateArray", 1)] 
		public CArrayFixedSize<audioAudioStateData> AnyStateArray
		{
			get
			{
				if (_anyStateArray == null)
				{
					_anyStateArray = (CArrayFixedSize<audioAudioStateData>) CR2WTypeManager.Create("[1]audioAudioStateData", "anyStateArray", cr2w, this);
				}
				return _anyStateArray;
			}
			set
			{
				if (_anyStateArray == value)
				{
					return;
				}
				_anyStateArray = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("states")] 
		public CArray<audioAudioStateData> States
		{
			get
			{
				if (_states == null)
				{
					_states = (CArray<audioAudioStateData>) CR2WTypeManager.Create("array:audioAudioStateData", "states", cr2w, this);
				}
				return _states;
			}
			set
			{
				if (_states == value)
				{
					return;
				}
				_states = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("anyStateTransitionsTable")] 
		public CArray<audioAnyStateTransitionEntry> AnyStateTransitionsTable
		{
			get
			{
				if (_anyStateTransitionsTable == null)
				{
					_anyStateTransitionsTable = (CArray<audioAnyStateTransitionEntry>) CR2WTypeManager.Create("array:audioAnyStateTransitionEntry", "anyStateTransitionsTable", cr2w, this);
				}
				return _anyStateTransitionsTable;
			}
			set
			{
				if (_anyStateTransitionsTable == value)
				{
					return;
				}
				_anyStateTransitionsTable = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("voLineSignals")] 
		public CArray<audioVoLineSignal> VoLineSignals
		{
			get
			{
				if (_voLineSignals == null)
				{
					_voLineSignals = (CArray<audioVoLineSignal>) CR2WTypeManager.Create("array:audioVoLineSignal", "voLineSignals", cr2w, this);
				}
				return _voLineSignals;
			}
			set
			{
				if (_voLineSignals == value)
				{
					return;
				}
				_voLineSignals = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("signalLeadingToShutdown")] 
		public CName SignalLeadingToShutdown
		{
			get
			{
				if (_signalLeadingToShutdown == null)
				{
					_signalLeadingToShutdown = (CName) CR2WTypeManager.Create("CName", "signalLeadingToShutdown", cr2w, this);
				}
				return _signalLeadingToShutdown;
			}
			set
			{
				if (_signalLeadingToShutdown == value)
				{
					return;
				}
				_signalLeadingToShutdown = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("templateScene")] 
		public CName TemplateScene
		{
			get
			{
				if (_templateScene == null)
				{
					_templateScene = (CName) CR2WTypeManager.Create("CName", "templateScene", cr2w, this);
				}
				return _templateScene;
			}
			set
			{
				if (_templateScene == value)
				{
					return;
				}
				_templateScene = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("templateSceneStateOverrides")] 
		public CArray<audioAudioSceneStateOverride> TemplateSceneStateOverrides
		{
			get
			{
				if (_templateSceneStateOverrides == null)
				{
					_templateSceneStateOverrides = (CArray<audioAudioSceneStateOverride>) CR2WTypeManager.Create("array:audioAudioSceneStateOverride", "templateSceneStateOverrides", cr2w, this);
				}
				return _templateSceneStateOverrides;
			}
			set
			{
				if (_templateSceneStateOverrides == value)
				{
					return;
				}
				_templateSceneStateOverrides = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("templateSceneSignalOverrides")] 
		public CArray<audioAudioSceneSignalOverride> TemplateSceneSignalOverrides
		{
			get
			{
				if (_templateSceneSignalOverrides == null)
				{
					_templateSceneSignalOverrides = (CArray<audioAudioSceneSignalOverride>) CR2WTypeManager.Create("array:audioAudioSceneSignalOverride", "templateSceneSignalOverrides", cr2w, this);
				}
				return _templateSceneSignalOverrides;
			}
			set
			{
				if (_templateSceneSignalOverrides == value)
				{
					return;
				}
				_templateSceneSignalOverrides = value;
				PropertySet(this);
			}
		}

		public audioAudioSceneData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
