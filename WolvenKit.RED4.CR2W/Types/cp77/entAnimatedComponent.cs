using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entAnimatedComponent : entISkinableComponent
	{
		private CHandle<entAnimationControlBinding> _controlBinding;
		private rRef<animRig> _rig;
		private rRef<animAnimGraph> _graph;
		private animAnimSetup _animations;
		private redTagList _animTags;
		private CName _audioAltName;
		private CBool _useLongRangeVisibility;
		private raRef<animFacialSetup> _facialSetup;
		private CBool _calculateAccelerationWs;
		private CArray<entAnimTrackParameter> _animParameters;
		private CInt32 _serverForcedLod;
		private CInt32 _clientForcedLod;
		private CBool _serverForcedVisibility;
		private CBool _clientForcedVisibility;

		[Ordinal(5)] 
		[RED("controlBinding")] 
		public CHandle<entAnimationControlBinding> ControlBinding
		{
			get
			{
				if (_controlBinding == null)
				{
					_controlBinding = (CHandle<entAnimationControlBinding>) CR2WTypeManager.Create("handle:entAnimationControlBinding", "controlBinding", cr2w, this);
				}
				return _controlBinding;
			}
			set
			{
				if (_controlBinding == value)
				{
					return;
				}
				_controlBinding = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("rig")] 
		public rRef<animRig> Rig
		{
			get
			{
				if (_rig == null)
				{
					_rig = (rRef<animRig>) CR2WTypeManager.Create("rRef:animRig", "rig", cr2w, this);
				}
				return _rig;
			}
			set
			{
				if (_rig == value)
				{
					return;
				}
				_rig = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("graph")] 
		public rRef<animAnimGraph> Graph
		{
			get
			{
				if (_graph == null)
				{
					_graph = (rRef<animAnimGraph>) CR2WTypeManager.Create("rRef:animAnimGraph", "graph", cr2w, this);
				}
				return _graph;
			}
			set
			{
				if (_graph == value)
				{
					return;
				}
				_graph = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("animations")] 
		public animAnimSetup Animations
		{
			get
			{
				if (_animations == null)
				{
					_animations = (animAnimSetup) CR2WTypeManager.Create("animAnimSetup", "animations", cr2w, this);
				}
				return _animations;
			}
			set
			{
				if (_animations == value)
				{
					return;
				}
				_animations = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("animTags")] 
		public redTagList AnimTags
		{
			get
			{
				if (_animTags == null)
				{
					_animTags = (redTagList) CR2WTypeManager.Create("redTagList", "animTags", cr2w, this);
				}
				return _animTags;
			}
			set
			{
				if (_animTags == value)
				{
					return;
				}
				_animTags = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("audioAltName")] 
		public CName AudioAltName
		{
			get
			{
				if (_audioAltName == null)
				{
					_audioAltName = (CName) CR2WTypeManager.Create("CName", "audioAltName", cr2w, this);
				}
				return _audioAltName;
			}
			set
			{
				if (_audioAltName == value)
				{
					return;
				}
				_audioAltName = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("useLongRangeVisibility")] 
		public CBool UseLongRangeVisibility
		{
			get
			{
				if (_useLongRangeVisibility == null)
				{
					_useLongRangeVisibility = (CBool) CR2WTypeManager.Create("Bool", "useLongRangeVisibility", cr2w, this);
				}
				return _useLongRangeVisibility;
			}
			set
			{
				if (_useLongRangeVisibility == value)
				{
					return;
				}
				_useLongRangeVisibility = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("facialSetup")] 
		public raRef<animFacialSetup> FacialSetup
		{
			get
			{
				if (_facialSetup == null)
				{
					_facialSetup = (raRef<animFacialSetup>) CR2WTypeManager.Create("raRef:animFacialSetup", "facialSetup", cr2w, this);
				}
				return _facialSetup;
			}
			set
			{
				if (_facialSetup == value)
				{
					return;
				}
				_facialSetup = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("calculateAccelerationWs")] 
		public CBool CalculateAccelerationWs
		{
			get
			{
				if (_calculateAccelerationWs == null)
				{
					_calculateAccelerationWs = (CBool) CR2WTypeManager.Create("Bool", "calculateAccelerationWs", cr2w, this);
				}
				return _calculateAccelerationWs;
			}
			set
			{
				if (_calculateAccelerationWs == value)
				{
					return;
				}
				_calculateAccelerationWs = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("animParameters")] 
		public CArray<entAnimTrackParameter> AnimParameters
		{
			get
			{
				if (_animParameters == null)
				{
					_animParameters = (CArray<entAnimTrackParameter>) CR2WTypeManager.Create("array:entAnimTrackParameter", "animParameters", cr2w, this);
				}
				return _animParameters;
			}
			set
			{
				if (_animParameters == value)
				{
					return;
				}
				_animParameters = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("serverForcedLod")] 
		public CInt32 ServerForcedLod
		{
			get
			{
				if (_serverForcedLod == null)
				{
					_serverForcedLod = (CInt32) CR2WTypeManager.Create("Int32", "serverForcedLod", cr2w, this);
				}
				return _serverForcedLod;
			}
			set
			{
				if (_serverForcedLod == value)
				{
					return;
				}
				_serverForcedLod = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("clientForcedLod")] 
		public CInt32 ClientForcedLod
		{
			get
			{
				if (_clientForcedLod == null)
				{
					_clientForcedLod = (CInt32) CR2WTypeManager.Create("Int32", "clientForcedLod", cr2w, this);
				}
				return _clientForcedLod;
			}
			set
			{
				if (_clientForcedLod == value)
				{
					return;
				}
				_clientForcedLod = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("serverForcedVisibility")] 
		public CBool ServerForcedVisibility
		{
			get
			{
				if (_serverForcedVisibility == null)
				{
					_serverForcedVisibility = (CBool) CR2WTypeManager.Create("Bool", "serverForcedVisibility", cr2w, this);
				}
				return _serverForcedVisibility;
			}
			set
			{
				if (_serverForcedVisibility == value)
				{
					return;
				}
				_serverForcedVisibility = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("clientForcedVisibility")] 
		public CBool ClientForcedVisibility
		{
			get
			{
				if (_clientForcedVisibility == null)
				{
					_clientForcedVisibility = (CBool) CR2WTypeManager.Create("Bool", "clientForcedVisibility", cr2w, this);
				}
				return _clientForcedVisibility;
			}
			set
			{
				if (_clientForcedVisibility == value)
				{
					return;
				}
				_clientForcedVisibility = value;
				PropertySet(this);
			}
		}

		public entAnimatedComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
