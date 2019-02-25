// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Bus : Gst.Object {

		public Bus (IntPtr raw) : base(raw) {}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_bus_new();

		public Bus () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Bus)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gst_bus_new();
		}

		[GLib.Signal("message")]
		public event Gst.MessageHandler Message {
			add {
				this.AddSignalHandler ("message", value, typeof (Gst.MessageArgs));
			}
			remove {
				this.RemoveSignalHandler ("message", value);
			}
		}

		[GLib.Signal("sync-message")]
		public event Gst.SyncMessageHandler SyncMessage {
			add {
				this.AddSignalHandler ("sync-message", value, typeof (Gst.SyncMessageArgs));
			}
			remove {
				this.RemoveSignalHandler ("sync-message", value);
			}
		}

		static MessageNativeDelegate Message_cb_delegate;
		static MessageNativeDelegate MessageVMCallback {
			get {
				if (Message_cb_delegate == null)
					Message_cb_delegate = new MessageNativeDelegate (Message_cb);
				return Message_cb_delegate;
			}
		}

		static void OverrideMessage (GLib.GType gtype)
		{
			OverrideMessage (gtype, MessageVMCallback);
		}

		static void OverrideMessage (GLib.GType gtype, MessageNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("message"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void MessageNativeDelegate (IntPtr inst, IntPtr message);

		static void Message_cb (IntPtr inst, IntPtr message)
		{
			try {
				Bus __obj = GLib.Object.GetObject (inst, false) as Bus;
				__obj.OnMessage (message == IntPtr.Zero ? null : (Gst.Message) GLib.Opaque.GetOpaque (message, typeof (Gst.Message), false));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.Bus), ConnectionMethod="OverrideMessage")]
		protected virtual void OnMessage (Gst.Message message)
		{
			InternalMessage (message);
		}

		private void InternalMessage (Gst.Message message)
		{
			MessageNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("message"));
				unmanaged = (MessageNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(MessageNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle, message == null ? IntPtr.Zero : message.Handle);
		}

		static SyncMessageNativeDelegate SyncMessage_cb_delegate;
		static SyncMessageNativeDelegate SyncMessageVMCallback {
			get {
				if (SyncMessage_cb_delegate == null)
					SyncMessage_cb_delegate = new SyncMessageNativeDelegate (SyncMessage_cb);
				return SyncMessage_cb_delegate;
			}
		}

		static void OverrideSyncMessage (GLib.GType gtype)
		{
			OverrideSyncMessage (gtype, SyncMessageVMCallback);
		}

		static void OverrideSyncMessage (GLib.GType gtype, SyncMessageNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("sync_message"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void SyncMessageNativeDelegate (IntPtr inst, IntPtr message);

		static void SyncMessage_cb (IntPtr inst, IntPtr message)
		{
			try {
				Bus __obj = GLib.Object.GetObject (inst, false) as Bus;
				__obj.OnSyncMessage (message == IntPtr.Zero ? null : (Gst.Message) GLib.Opaque.GetOpaque (message, typeof (Gst.Message), false));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.Bus), ConnectionMethod="OverrideSyncMessage")]
		protected virtual void OnSyncMessage (Gst.Message message)
		{
			InternalSyncMessage (message);
		}

		private void InternalSyncMessage (Gst.Message message)
		{
			SyncMessageNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("sync_message"));
				unmanaged = (SyncMessageNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(SyncMessageNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle, message == null ? IntPtr.Zero : message.Handle);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("message"
							, Gst.Object.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // message
							, null
							, "sync_message"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("sync_message"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // sync_message
							, "message"
							, "_gst_reserved"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gst_reserved"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _gst_reserved
							, "sync_message"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_bus_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_bus_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_bus_add_signal_watch(IntPtr raw);

		public void AddSignalWatch() {
			gst_bus_add_signal_watch(Handle);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_bus_add_signal_watch_full(IntPtr raw, int priority);

		public void AddSignalWatchFull(int priority) {
			gst_bus_add_signal_watch_full(Handle, priority);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint gst_bus_add_watch_full(IntPtr raw, int priority, GstSharp.BusFuncNative func, IntPtr user_data, GLib.DestroyNotify notify);

		public uint AddWatchFull(int priority, Gst.BusFunc func) {
			GstSharp.BusFuncWrapper func_wrapper = new GstSharp.BusFuncWrapper (func);
			IntPtr user_data;
			GLib.DestroyNotify notify;
			if (func == null) {
				user_data = IntPtr.Zero;
				notify = null;
			} else {
				user_data = (IntPtr) GCHandle.Alloc (func_wrapper);
				notify = GLib.DestroyHelper.NotifyHandler;
			}
			uint raw_ret = gst_bus_add_watch_full(Handle, priority, func_wrapper.NativeDelegate, user_data, notify);
			uint ret = raw_ret;
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_bus_async_signal_func(IntPtr raw, IntPtr message, IntPtr data);

		public bool AsyncSignalFunc(Gst.Message message, IntPtr data) {
			bool raw_ret = gst_bus_async_signal_func(Handle, message == null ? IntPtr.Zero : message.Handle, data);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_bus_create_watch(IntPtr raw);

		public GLib.Source CreateWatch() {
			IntPtr raw_ret = gst_bus_create_watch(Handle);
			GLib.Source ret = new GLib.Source(raw_ret);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_bus_disable_sync_message_emission(IntPtr raw);

		public void DisableSyncMessageEmission() {
			gst_bus_disable_sync_message_emission(Handle);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_bus_enable_sync_message_emission(IntPtr raw);

		public void EnableSyncMessageEmission() {
			gst_bus_enable_sync_message_emission(Handle);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_bus_get_pollfd(IntPtr raw, out GLib.PollFD fd);

		public GLib.PollFD Pollfd { 
			get {
				GLib.PollFD fd;
				gst_bus_get_pollfd(Handle, out fd);
				return fd;
			}
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_bus_have_pending(IntPtr raw);

		public bool HavePending() {
			bool raw_ret = gst_bus_have_pending(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_bus_peek(IntPtr raw);

		public Gst.Message Peek() {
			IntPtr raw_ret = gst_bus_peek(Handle);
			Gst.Message ret = raw_ret == IntPtr.Zero ? null : (Gst.Message) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Message), true);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_bus_poll(IntPtr raw, int events, ulong timeout);

		public Gst.Message Poll(Gst.MessageType events, ulong timeout) {
			IntPtr raw_ret = gst_bus_poll(Handle, (int) events, timeout);
			Gst.Message ret = raw_ret == IntPtr.Zero ? null : (Gst.Message) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Message), true);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_bus_pop(IntPtr raw);

		public Gst.Message Pop() {
			IntPtr raw_ret = gst_bus_pop(Handle);
			Gst.Message ret = raw_ret == IntPtr.Zero ? null : (Gst.Message) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Message), true);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_bus_pop_filtered(IntPtr raw, int types);

		public Gst.Message PopFiltered(Gst.MessageType types) {
			IntPtr raw_ret = gst_bus_pop_filtered(Handle, (int) types);
			Gst.Message ret = raw_ret == IntPtr.Zero ? null : (Gst.Message) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Message), true);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_bus_post(IntPtr raw, IntPtr message);

		public bool Post(Gst.Message message) {
			message.Owned = false;
			bool raw_ret = gst_bus_post(Handle, message == null ? IntPtr.Zero : message.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_bus_remove_signal_watch(IntPtr raw);

		public void RemoveSignalWatch() {
			gst_bus_remove_signal_watch(Handle);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_bus_remove_watch(IntPtr raw);

		public bool RemoveWatch() {
			bool raw_ret = gst_bus_remove_watch(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_bus_set_flushing(IntPtr raw, bool flushing);

		public bool Flushing { 
			set {
				gst_bus_set_flushing(Handle, value);
			}
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_bus_set_sync_handler(IntPtr raw, GstSharp.BusSyncHandlerNative func, IntPtr user_data, GLib.DestroyNotify notify);

		public Gst.BusSyncHandler SyncHandler { 
			set {
				GstSharp.BusSyncHandlerWrapper value_wrapper = new GstSharp.BusSyncHandlerWrapper (value);
				IntPtr user_data;
				GLib.DestroyNotify notify;
				if (value == null) {
					user_data = IntPtr.Zero;
					notify = null;
				} else {
					user_data = (IntPtr) GCHandle.Alloc (value_wrapper);
					notify = GLib.DestroyHelper.NotifyHandler;
				}
				gst_bus_set_sync_handler(Handle, value_wrapper.NativeDelegate, user_data, notify);
			}
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_bus_sync_signal_handler(IntPtr raw, IntPtr message, IntPtr data);

		public Gst.BusSyncReply SyncSignalHandler(Gst.Message message) {
			int raw_ret = gst_bus_sync_signal_handler(Handle, message == null ? IntPtr.Zero : message.Handle, IntPtr.Zero);
			Gst.BusSyncReply ret = (Gst.BusSyncReply) raw_ret;
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_bus_timed_pop(IntPtr raw, ulong timeout);

		public Gst.Message TimedPop(ulong timeout) {
			IntPtr raw_ret = gst_bus_timed_pop(Handle, timeout);
			Gst.Message ret = raw_ret == IntPtr.Zero ? null : (Gst.Message) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Message), true);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_bus_timed_pop_filtered(IntPtr raw, ulong timeout, int types);

		public Gst.Message TimedPopFiltered(ulong timeout, Gst.MessageType types) {
			IntPtr raw_ret = gst_bus_timed_pop_filtered(Handle, timeout, (int) types);
			Gst.Message ret = raw_ret == IntPtr.Zero ? null : (Gst.Message) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Message), true);
			return ret;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, Gst.Object.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // priv
							, null
							, "_gst_reserved"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gst_reserved"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _gst_reserved
							, "priv"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
