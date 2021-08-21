using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LinkedStatusEffectListener : gameScriptStatusEffectListener
	{
		private wCHandle<gameObject> _instigatorObject;
		private TweakDBID _linkedEffect;
		private CHandle<RemoveLinkedStatusEffectsEvent> _evt;

		[Ordinal(0)] 
		[RED("instigatorObject")] 
		public wCHandle<gameObject> InstigatorObject
		{
			get => GetProperty(ref _instigatorObject);
			set => SetProperty(ref _instigatorObject, value);
		}

		[Ordinal(1)] 
		[RED("linkedEffect")] 
		public TweakDBID LinkedEffect
		{
			get => GetProperty(ref _linkedEffect);
			set => SetProperty(ref _linkedEffect, value);
		}

		[Ordinal(2)] 
		[RED("evt")] 
		public CHandle<RemoveLinkedStatusEffectsEvent> Evt
		{
			get => GetProperty(ref _evt);
			set => SetProperty(ref _evt, value);
		}

		public LinkedStatusEffectListener(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
