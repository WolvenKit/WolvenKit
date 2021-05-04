using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SNetworkLinkData : CVariable
	{
		private CHandle<gameFxInstance> _beam;
		private gameFxResource _fxResource;
		private entEntityID _slaveID;
		private entEntityID _masterID;
		private Vector4 _slavePos;
		private Vector4 _masterPos;
		private CBool _drawLink;
		private CBool _isActive;
		private CBool _isDynamic;
		private CBool _revealMaster;
		private CBool _revealSlave;
		private CBool _permanent;
		private CBool _isPing;
		private CBool _isNetrunner;
		private CEnum<ELinkType> _linkType;
		private CEnum<EPriority> _priority;
		private CFloat _lifetime;
		private gameDelayID _delayID;
		private CBool _weakLink;

		[Ordinal(0)] 
		[RED("beam")] 
		public CHandle<gameFxInstance> Beam
		{
			get => GetProperty(ref _beam);
			set => SetProperty(ref _beam, value);
		}

		[Ordinal(1)] 
		[RED("fxResource")] 
		public gameFxResource FxResource
		{
			get => GetProperty(ref _fxResource);
			set => SetProperty(ref _fxResource, value);
		}

		[Ordinal(2)] 
		[RED("slaveID")] 
		public entEntityID SlaveID
		{
			get => GetProperty(ref _slaveID);
			set => SetProperty(ref _slaveID, value);
		}

		[Ordinal(3)] 
		[RED("masterID")] 
		public entEntityID MasterID
		{
			get => GetProperty(ref _masterID);
			set => SetProperty(ref _masterID, value);
		}

		[Ordinal(4)] 
		[RED("slavePos")] 
		public Vector4 SlavePos
		{
			get => GetProperty(ref _slavePos);
			set => SetProperty(ref _slavePos, value);
		}

		[Ordinal(5)] 
		[RED("masterPos")] 
		public Vector4 MasterPos
		{
			get => GetProperty(ref _masterPos);
			set => SetProperty(ref _masterPos, value);
		}

		[Ordinal(6)] 
		[RED("drawLink")] 
		public CBool DrawLink
		{
			get => GetProperty(ref _drawLink);
			set => SetProperty(ref _drawLink, value);
		}

		[Ordinal(7)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetProperty(ref _isActive);
			set => SetProperty(ref _isActive, value);
		}

		[Ordinal(8)] 
		[RED("isDynamic")] 
		public CBool IsDynamic
		{
			get => GetProperty(ref _isDynamic);
			set => SetProperty(ref _isDynamic, value);
		}

		[Ordinal(9)] 
		[RED("revealMaster")] 
		public CBool RevealMaster
		{
			get => GetProperty(ref _revealMaster);
			set => SetProperty(ref _revealMaster, value);
		}

		[Ordinal(10)] 
		[RED("revealSlave")] 
		public CBool RevealSlave
		{
			get => GetProperty(ref _revealSlave);
			set => SetProperty(ref _revealSlave, value);
		}

		[Ordinal(11)] 
		[RED("permanent")] 
		public CBool Permanent
		{
			get => GetProperty(ref _permanent);
			set => SetProperty(ref _permanent, value);
		}

		[Ordinal(12)] 
		[RED("isPing")] 
		public CBool IsPing
		{
			get => GetProperty(ref _isPing);
			set => SetProperty(ref _isPing, value);
		}

		[Ordinal(13)] 
		[RED("isNetrunner")] 
		public CBool IsNetrunner
		{
			get => GetProperty(ref _isNetrunner);
			set => SetProperty(ref _isNetrunner, value);
		}

		[Ordinal(14)] 
		[RED("linkType")] 
		public CEnum<ELinkType> LinkType
		{
			get => GetProperty(ref _linkType);
			set => SetProperty(ref _linkType, value);
		}

		[Ordinal(15)] 
		[RED("priority")] 
		public CEnum<EPriority> Priority
		{
			get => GetProperty(ref _priority);
			set => SetProperty(ref _priority, value);
		}

		[Ordinal(16)] 
		[RED("lifetime")] 
		public CFloat Lifetime
		{
			get => GetProperty(ref _lifetime);
			set => SetProperty(ref _lifetime, value);
		}

		[Ordinal(17)] 
		[RED("delayID")] 
		public gameDelayID DelayID
		{
			get => GetProperty(ref _delayID);
			set => SetProperty(ref _delayID, value);
		}

		[Ordinal(18)] 
		[RED("weakLink")] 
		public CBool WeakLink
		{
			get => GetProperty(ref _weakLink);
			set => SetProperty(ref _weakLink, value);
		}

		public SNetworkLinkData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
