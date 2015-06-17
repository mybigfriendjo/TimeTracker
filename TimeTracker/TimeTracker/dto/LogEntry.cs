using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker.dto {
	class LogEntry {
		public LogEntry(DateTime timestamp, bool begin, string entry) {
			this.Timestamp = timestamp;
			this.Begin = begin;
			this.Entry = entry;
		}

		public DateTime Timestamp {
			get;
			private set;
		}

		public bool Begin {
			get;
			private set;
		}

		public string Entry {
			get;
			private set;
		}
	}
}
