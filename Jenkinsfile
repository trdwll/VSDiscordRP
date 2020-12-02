
pipeline {
  agent {
    node {
      label 'Windows'
    }

  }
  
  stages {

    stage('Build Release') {
      steps {
        bat "\"${tool 'MSBuild'}\" VSDiscordRP.csproj /p:Configuration=Release"
      }
    }

    stage('Build Debug') {
      steps {
        bat "\"${tool 'MSBuild'}\" VSDiscordRP.csproj /p:Configuration=Debug"
      }
    }

  }
}
