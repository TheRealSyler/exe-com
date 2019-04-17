import * as Process from 'child_process';

export class Execute {
  constructor(private _extensionPath: string) {}

  Launch() {
    console.log('213');
    Process.exec(
      `WpfApp1.exe true`,
      { cwd: this._extensionPath },
      (error, stdout: string, stderr: string) => {
        const output = stdout.split(',');
        if (output[0] === 'testOutput') {
          console.log('Output: == "testOutput"');
        }
      }
    );
  }
}
