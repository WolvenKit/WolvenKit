using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class enteventsPhysicalCollisionEvent : redEvent
	{
		private wCHandle<IScriptable> _myComponent;
		private wCHandle<IScriptable> _otherEntity;
		private wCHandle<IScriptable> _otherComponent;
		private Vector4 _worldPosition;
		private Vector4 _worldNormal;
		private Vector4 _deltaVelocity;
		private CFloat _impulse;

		[Ordinal(0)] 
		[RED("myComponent")] 
		public wCHandle<IScriptable> MyComponent
		{
			get => GetProperty(ref _myComponent);
			set => SetProperty(ref _myComponent, value);
		}

		[Ordinal(1)] 
		[RED("otherEntity")] 
		public wCHandle<IScriptable> OtherEntity
		{
			get => GetProperty(ref _otherEntity);
			set => SetProperty(ref _otherEntity, value);
		}

		[Ordinal(2)] 
		[RED("otherComponent")] 
		public wCHandle<IScriptable> OtherComponent
		{
			get => GetProperty(ref _otherComponent);
			set => SetProperty(ref _otherComponent, value);
		}

		[Ordinal(3)] 
		[RED("worldPosition")] 
		public Vector4 WorldPosition
		{
			get => GetProperty(ref _worldPosition);
			set => SetProperty(ref _worldPosition, value);
		}

		[Ordinal(4)] 
		[RED("worldNormal")] 
		public Vector4 WorldNormal
		{
			get => GetProperty(ref _worldNormal);
			set => SetProperty(ref _worldNormal, value);
		}

		[Ordinal(5)] 
		[RED("deltaVelocity")] 
		public Vector4 DeltaVelocity
		{
			get => GetProperty(ref _deltaVelocity);
			set => SetProperty(ref _deltaVelocity, value);
		}

		[Ordinal(6)] 
		[RED("impulse")] 
		public CFloat Impulse
		{
			get => GetProperty(ref _impulse);
			set => SetProperty(ref _impulse, value);
		}

		public enteventsPhysicalCollisionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
